using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour
{
    public static ScreenFader Instance;

    [SerializeField] private Image blackPanel;
    [SerializeField] private float fadeDuration = 0.5f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public IEnumerator FadeIn()
    {
        yield return Fade(1f, 0f);
    }

    public IEnumerator FadeOut()
    {
        yield return Fade(0f, 1f);
    }

    private IEnumerator Fade(float from, float to)
    {
        float time = 0f;

        Color color = blackPanel.color;
        color.a = from;
        blackPanel.color = color;

        blackPanel.raycastTarget = true;

        while (time < fadeDuration)
        {
            time += Time.unscaledDeltaTime;

            color.a = Mathf.Lerp(from, to, time / fadeDuration);
            blackPanel.color = color;

            yield return null;
        }

        color.a = to;
        blackPanel.color = color;

        blackPanel.raycastTarget = to > 0.95f;
    }
}