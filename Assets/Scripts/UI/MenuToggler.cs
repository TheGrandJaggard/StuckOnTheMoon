using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuToggler : MonoBehaviour
{
    public GameObject Menu;
    private TimeManager TimeManagerScript;
    private bool MenuActive;

    public void Start()
    {
        Menu.SetActive(false);
        MenuActive = false;

        TimeManagerScript = GameObject.FindWithTag("GameController").GetComponent<TimeManager>();
    }

    public void OnToggleMenu()
    {
        if (MenuActive == false)
        {
            Menu.SetActive(true);
            MenuActive = true;

            TimeManagerScript.Pause(true);
        }
        else
        {
            Menu.SetActive(false);
            MenuActive = false;

            TimeManagerScript.Pause(false);
        }
    }
}
