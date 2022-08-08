using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private float NormalGameSpeed = 1;
    private float CurrentGameSpeed;
    private bool GamePaused;

    void Start()
    {
        CurrentGameSpeed = NormalGameSpeed;
    }

    void Update()
    {
        if (GamePaused == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = CurrentGameSpeed;
        }
    }

    public void SetTimeSpeed(float Speed)
    {
        CurrentGameSpeed = Speed;
    }

    public void Pause(bool var)
    {
        GamePaused = var;
    }
}
