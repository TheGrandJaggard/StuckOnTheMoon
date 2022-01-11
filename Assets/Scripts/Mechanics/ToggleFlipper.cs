using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyBoolFlippedEvent : UnityEvent<bool> { }

public class ToggleFlipper : MonoBehaviour
{
    public MyBoolFlippedEvent MyEvent;

    public void FlipBool(bool ToggledOn)
    {
        if (ToggledOn == true) { ToggledOn = false; }
        else if (ToggledOn == false) { ToggledOn = true; }

        if (MyEvent == null)
            MyEvent = new MyBoolFlippedEvent();
        MyEvent.Invoke(ToggledOn);
    }
}
