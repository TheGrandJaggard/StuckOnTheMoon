using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A simple controller for switching between UI panels.
/// </summary>
public class PanelController : MonoBehaviour
{
    public bool SetFirstPanelOnEnable;
    public GameObject[] panels;

    public void SetActivePanel(int index)
    {
        for (var i = 0; i < panels.Length; i++)
        {
            var active = i == index;
            var g = panels[i];
            if (g.activeSelf != active) g.SetActive(active);
        }
    }

    void OnEnable()
    {
        if (SetFirstPanelOnEnable == true)
        {
            SetActivePanel(0);
        }
    }
}
