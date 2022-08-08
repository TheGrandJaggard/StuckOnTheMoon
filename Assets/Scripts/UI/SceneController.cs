using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoBackToMenu()
    {
        SceneManager.LoadScene("StartingScene");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenSceneByName(string Name)
    {
        SceneManager.LoadScene(Name);
    }

    public void OpenSceneByNumber(int Number)
    {
        SceneManager.LoadScene("Scene " + Number.ToString());
    }
}
