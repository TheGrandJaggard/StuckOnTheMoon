using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuToggler : MonoBehaviour
{
    public GameObject Menu;
    private bool MenuToggled;

    public void Start()
    {
        Menu.SetActive(false);
        MenuToggled = false;
    }

    public void OnToggleMenu()
    {
        if (MenuToggled == false)
        {
            Menu.SetActive(true);
            MenuToggled = true;
            Time.timeScale = 0;
        }
        else
        {
            Menu.SetActive(false);
            MenuToggled = false;
            Time.timeScale = 1;
        }
    }
}
