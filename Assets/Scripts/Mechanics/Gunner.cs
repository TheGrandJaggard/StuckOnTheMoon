using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Gunner : MonoBehaviour
{
    private AudioSource Audio;
    [Tooltip("Plays every time the gun is fired")]
    public AudioClip FiredClip;

    private Transform FirePoint;
    private bool WantToShoot = false;
    private int CanFireNext = 0;

    [Tooltip("Minimum delay between shots measured in Fixed Update frames")]
    public int FiringDelay;

    [Header("Bullet Settings")]
    [SerializeField] private GameObject BulletPrefab;
    [Tooltip("Leave empty if this bullet does not explode")]
    [SerializeField] private GameObject ExplosionPrefab;
    [Tooltip("Bullet Speed is how much force gets added on awake")]
    [SerializeField] private float BulletSpeed;
    [Tooltip("The weight of the bullet")]
    [SerializeField] private float BulletGravityScale;
    [SerializeField] private int BulletDamage;
    [SerializeField] private Vector2 BulletScale;
    [SerializeField] private bool BulletCanPierce;
    [SerializeField] private Sprite BulletSprite;

    void Start()
    {
        FirePoint = transform.Find("FirePoint");
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
        // Debug.Log("Shoot");

        GameObject NewestBullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        BulletScript BulletScript = NewestBullet.GetComponent<BulletScript>();
        BulletScript.SetVariables(ExplosionPrefab, BulletSpeed, BulletGravityScale, BulletDamage, BulletScale, BulletCanPierce, BulletSprite);

        Audio.clip = FiredClip;
        Audio.Play();
    }
}
