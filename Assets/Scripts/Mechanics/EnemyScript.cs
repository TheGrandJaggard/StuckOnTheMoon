using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class EnemyScript : MonoBehaviour
{
    public UnityEvent OnDeath;

    public AudioClip DeathClip;
    public AudioClip EnemyHurtClip;
    public AudioMixerGroup OutputMixerGroup;
    private AudioSource Audio;
    private GameObject GFX;
    private GameObject HealthBarCanvas;
    private Slider HealthBarSlider;

    private bool CanHurt = true;
    public int MaxHealth;
    private int Health;
    public int Damage;

    void Start()
    {
        GFX = gameObject.transform.Find("GFX").gameObject;
        HealthBarCanvas = gameObject.transform.Find("HealthBarCanvas").gameObject;
        HealthBarSlider = HealthBarCanvas.transform.Find("HealthBarSlider").gameObject.GetComponent<Slider>();
        Health = MaxHealth;
        HealthBarSlider.maxValue = MaxHealth;
        HealthBarSlider.value = Health;

        Audio = GetComponent<AudioSource>();
        Audio.outputAudioMixerGroup = OutputMixerGroup;
    }

    public void TakeDamage(int DamageTaken)
    {
        Audio.clip = EnemyHurtClip;
        Audio.Play();

        Health -= DamageTaken;

        HealthBarSlider.value = Health;

        if (Health <= 0)
        {
            Die();
        }
    }

    void OnTriggerEnter2D(Collider2D Info)
    {
        PlayerHealth Player = Info.GetComponent<PlayerHealth>();

        if (Player != null && CanHurt == true)
        {
            Player.TakeDamage(Damage);
        }
    }

    void Die()
    {
        HealthBarCanvas.SetActive(false);
        GFX.SetActive(false);
        CanHurt = false;
        Audio.clip = DeathClip;
        Audio.Play();
        OnDeath.Invoke();
        Invoke("SelfDestruct", 4);
    }

    private void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
