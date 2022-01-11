using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyBoolEvent : UnityEvent<bool> { }

public class LeverScript : MonoBehaviour
{
    public MyBoolEvent MyEvent;
    private bool PlayerIsHere = false;
    public bool ToggledOn;
    SpriteRenderer Sprite;

    void Start()
    {
        Sprite = gameObject.GetComponent<SpriteRenderer>();
        Sprite.flipY = ToggledOn;

        Invoke("Starter", 0);
    }

    void Starter()
    {
        if (MyEvent == null)
            MyEvent = new MyBoolEvent();
        MyEvent.Invoke(ToggledOn);
    }

    void OnInteract()
    {
        if (PlayerIsHere == true)
        {
            if (ToggledOn == true)
            {
                //Debug.Log("'OnInteract' + ToggledOn = " + ToggledOn.ToString());
                ToggledOn = false;
            }
            else
            {
                //Debug.Log("'OnInteract' + ToggledOn = " + ToggledOn.ToString());
                ToggledOn = true;
            }
            Sprite.flipY = ToggledOn;

            if (MyEvent == null)
                MyEvent = new MyBoolEvent();
            MyEvent.Invoke(ToggledOn);
        }
    }

    void OnTriggerEnter2D(Collider2D Info)
    {
        if (Info.tag == "Player" || Info.tag == "Gun")
        {
            PlayerIsHere = true;
        }
    }

    void OnTriggerExit2D(Collider2D Info)
    {
        if (Info.tag == "Player" || Info.tag == "Gun")
        {
            PlayerIsHere = false;
        }
    }
}
