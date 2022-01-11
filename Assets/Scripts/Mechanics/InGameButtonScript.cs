using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class InGameButtonScript : MonoBehaviour
{
    public UnityEvent MyEvent;
    private bool PlayerIsHere = false;

    void OnInteract()
    {
        if (PlayerIsHere == true)
        {
            Debug.Log("PlayerIsHere = " + PlayerIsHere.ToString());

            MyEvent.Invoke();
        }
    }

    void OnTriggerEnter2D(Collider2D Info)
    {
        if (Info.tag == "Player")
        {
            PlayerIsHere = true;
            Debug.Log("OnTriggerEnter2D :: PlayerIsHere = " + PlayerIsHere.ToString());
        }
    }

    void OnTriggerExit2D(Collider2D Info)
    {
        if (Info.tag == "Player")
        {
            PlayerIsHere = false;
            Debug.Log("OnTriggerExit2D :: PlayerIsHere = " + PlayerIsHere.ToString());
        }
    }
}
