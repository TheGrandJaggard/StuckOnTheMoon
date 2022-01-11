using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class myeasytrigger : MonoBehaviour
{

    public UnityEvent MyEvent;
    public int HowLongToWait = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (tag == "Player") 
        {
            Invoke("dofunction", HowLongToWait);
        }
    }

    void dofunction()
    {
        //Debug.Log("now!");
        MyEvent.Invoke();
    }
}
