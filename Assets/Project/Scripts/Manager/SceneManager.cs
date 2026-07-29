using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ParcelInspector.Core
{
    public class SceneManager : Singleton<SceneManager>
    {
        public event Action<SceneType> OnSceneLoaded;

        public SceneType CurrentScene { get; private set; }
        [SerializeField]
        private List<SceneData> sceneMappings;
        private bool isLoading;

        public void Initialize()
        {
            CurrentScene = SceneType.Bootstrap;
        }

        public void LoadScene(SceneType scene)
        {
            if (isLoading)
                return;

            StartCoroutine(LoadSceneRoutine(scene));
        }

        private IEnumerator LoadSceneRoutine(SceneType scene)
        {
            isLoading = true;

            GameManager.Instance.SetState(GameState.Loading);

            // Fade to black
            yield return ScreenFader.Instance.FadeOut();

            // Load scene
            AsyncOperation operation =
                UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(scene.ToString());

            operation.allowSceneActivation = true;

            while (!operation.isDone)
                yield return null;

            CurrentScene = scene;

            // Update game state
            UpdateGameState(scene);

            // Let UI initialize
            yield return null;

            // Fade back in
            yield return ScreenFader.Instance.FadeIn();

            OnSceneLoaded?.Invoke(scene);

            isLoading = false;
        }

        private void UpdateGameState(SceneType scene)
        {
            var mapping = sceneMappings.Find(s => s.SceneType == scene);

            if (mapping != null)
                GameManager.Instance.SetState(mapping.GameState);
        }
    }
}



public enum SceneType
{
    Bootstrap = 0,
    MainMenu = 1,
    Gameplay = 2,

    Loading = 3,

    Shop = 4,
    Settings = 5,
    Credits = 6,

    Test = 100
}
