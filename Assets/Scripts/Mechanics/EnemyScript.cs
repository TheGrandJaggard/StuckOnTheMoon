using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public class EnemyScript : MonoBehaviour
{
    public UnityEvent OnDeath;

    public AudioClip DeathClip;
    public AudioClip EnemyHurtClip;
    private AudioSource Audio;

    public int MaxHealth;
    private int Health;
    public int Damage;
    public Slider HealthBar;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Health = MaxHealth;
        HealthBar.maxValue = MaxHealth;
        HealthBar.value = Health;
    }

    public void TakeDamage(int DamageTaken)
    {
        Audio.clip = EnemyHurtClip;
        Audio.Play();

        Health -= DamageTaken;

        HealthBar.value = Health;

        if (Health <= 0)
        {
            Die();
        }
    }

    void OnTriggerEnter2D(Collider2D Info)
    {

        PlayerHealth Player = Info.GetComponent<PlayerHealth>();

        if (Player != null)
        {
            Player.TakeDamage(Damage);
        }
    }

    void Die()
    {
        Audio.clip = DeathClip;
        Audio.Play();
        OnDeath.Invoke();
        Destroy(gameObject);
    }
}
