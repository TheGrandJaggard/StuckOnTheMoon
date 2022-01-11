using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StuffController : MonoBehaviour
{
    public UnityEvent MyEvent;
    private int Number;
    public int NumberYouWant;

    public void AddNumber (int NumberToAdd)
    {
        Number += NumberToAdd;
    }

    public void SubtractNumber(int NumberToSubtract)
    {
        Number += NumberToSubtract;
    }

    void Update()
    {
        if (Number == NumberYouWant)
        {
            MyEvent.Invoke();
        }
    }
}
