using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SpawnObject;

    public void Spawn()
    {
        Instantiate(SpawnObject, transform.position, transform.rotation);
    }
}