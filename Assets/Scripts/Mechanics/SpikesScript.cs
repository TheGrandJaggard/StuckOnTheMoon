using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesScript : MonoBehaviour
{

    public int Damage;

    void OnTriggerEnter2D(Collider2D Info)
    {
        PlayerHealth Player = Info.GetComponent<PlayerHealth>();

        if (Player != null)
        {
            Player.TakeDamage(Damage);
        }
    }
}
