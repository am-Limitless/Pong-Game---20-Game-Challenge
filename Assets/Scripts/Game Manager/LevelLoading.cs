using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("2nd Menu");
    }

    public void QUIT()
    {
        Application.Quit();
    }

    public void PVP()
    {
        SceneManager.LoadScene("Player Vs Player");
    }

    public void PVEMode()
    {
        SceneManager.LoadScene("AI MODE");
    }

    public void easyMode()
    {
        SceneManager.LoadScene("Easy Mode");
    }

    public void hardMode()
    {
        SceneManager.LoadScene("Hard Mode");
    }

    public void menuSelect()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartLevel()
    {
        // Get the current active scene and reload it
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
