using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Gunner : MonoBehaviour
{
    private AudioSource Audio;
    public AudioClip FiredClip;

    public Transform FirePoint;

    public GameObject Bullet;

    private bool WantToShoot = false;
    private int CanFireNext = 0;
    public int FiringDelay;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    void OnStartFireing()
    {
        WantToShoot = true;
    }

    void OnStopFireing()
    {
        WantToShoot = false;
    }

    void FixedUpdate()
    {
        if (CanFireNext > 0)
        {
            CanFireNext -= 1;
        }

        //Debug.Log("CanFireNext = " + CanFireNext.ToString() + " :: WantToShoot = " + WantToShoot.ToString());

        if (CanFireNext == 0 && WantToShoot == true)
        {
            Shoot();
            CanFireNext = FiringDelay;
        }
    }

    void Shoot()
    {
        Debug.Log("Shoot");
        Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
        Audio.clip = FiredClip;
        Audio.Play();
    }
}
