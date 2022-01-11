using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameQuitter : MonoBehaviour
{
    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log ("game_was_terminated");
    }
}
