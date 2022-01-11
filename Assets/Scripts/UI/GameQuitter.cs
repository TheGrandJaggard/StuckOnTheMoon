using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu_script : MonoBehaviour
{
    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log ("game_was_terminated");
    }
}
