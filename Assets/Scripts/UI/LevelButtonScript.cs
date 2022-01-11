using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelButtonScript : MonoBehaviour
{
    // this is for the buttons in the play menu in the starting scene
    public TextMeshProUGUI ButtonText;
    public string LevelName;

    void Start()
    {
        ButtonText.text = LevelName;
    }

    public void PlayLevel()
    {
        SceneManager.LoadScene("Scene" + LevelName);
    }
}
