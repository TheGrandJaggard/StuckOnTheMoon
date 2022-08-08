using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Slider Healthbar;
    [SerializeField] private int MaxHealth;
    private int MyHealth;
    [SerializeField] private GameObject YouHaveDiedPanel;
    private AudioSource PlayerAudio;
    [SerializeField] private AudioClip PlayerHurt;
    [SerializeField] private AudioClip DieSound;



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
        //Debug.Log("MyHealth = " + MyHealth.ToString());
        Healthbar.value = MyHealth;

        if (MyHealth <= 0)
        {
            Die();
        }
    }

    public void GainHealth(int Health)
    {
        MyHealth += Health;
        //Debug.Log("MyHealth = " + MyHealth.ToString());
        Healthbar.value = MyHealth;
    }

    void Die()
    {
        PlayerAudio.clip = DieSound;
        PlayerAudio.Play();

        YouHaveDiedPanel.SetActive(true);
        GameObject.FindGameObjectWithTag("GameController").GetComponent<TimeManager>().SetTimeSpeed(0f);
    }

    /*
    void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    */
}