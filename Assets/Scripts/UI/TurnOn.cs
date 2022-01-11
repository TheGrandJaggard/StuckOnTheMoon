using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{
    public GameObject GameObject;
    void Start()
    {
        GameObject.SetActive(true);
    }
}
