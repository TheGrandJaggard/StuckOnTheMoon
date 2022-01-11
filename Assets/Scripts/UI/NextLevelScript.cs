using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{

    private string LevelName;
    private string LevelNumber;
    private int ThisLevelNumber;


    public void GoToNextLevel()
    {
        LevelName = SceneManager.GetActiveScene().name;
        LevelNumber = LevelName.Replace("Scene", "");

        char[] tmp = new char[] { ' ' };
        string[] strings = LevelNumber.Split(tmp);
        int result = int.Parse(strings[1]);
        Debug.Log(result);

        SceneManager.LoadScene("Scene" + LevelName);
    }
}
