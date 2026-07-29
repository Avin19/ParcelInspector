using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    public void Continue()
    {
        SaveManager.Instance.LoadGame();

        //SceneManager.Instance.LoadGameplay();
    }

    public void NewGame()
    {
        SaveManager.Instance.CreateNewGame();

        //SceneManager.Instance.LoadGameplay();
    }

    public void Shop()
    {

    }

    public void Achievement()
    {

    }

    public void Settings()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }
}