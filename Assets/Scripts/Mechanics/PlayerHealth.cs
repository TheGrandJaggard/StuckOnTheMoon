using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Slider Healthbar;
    public int MaxHealth;
    private int MyHealth;
    public GameObject YouHaveDiedPanel;
    private AudioSource PlayerAudio;
    public AudioClip PlayerHurt;
    public AudioClip DieSound;



    void Start()
    {
        PlayerAudio = GetComponent<AudioSource>();
        MyHealth = MaxHealth;
        Healthbar.maxValue = MaxHealth;
        Healthbar.value = MyHealth;
    }

    public void TakeDamage(int Damage)
    {
        PlayerAudio.clip = PlayerHurt;
        PlayerAudio.Play();

        MyHealth -= Damage;
        Debug.Log("MyHealth = " + MyHealth.ToString());
        Healthbar.value = MyHealth;

        if (MyHealth <= 0)
        {
            Die();
        }
    }

    public void GetHealth(int Health)
    {
        MyHealth += Health;
        Debug.Log("MyHealth = " + MyHealth.ToString());
        Healthbar.value = MyHealth;
    }

    void Die()
    {
        PlayerAudio.clip = DieSound;
        PlayerAudio.Play();

        YouHaveDiedPanel.SetActive(true);
    }

    /*
    void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    */
}