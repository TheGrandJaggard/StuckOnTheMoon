using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class DummyScript : MonoBehaviour
{
    
    public AudioClip DummyHitClip;
    public AudioMixerGroup OutputMixerGroup;
    private AudioSource Audio;
    public TMP_Text DamageText;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.outputAudioMixerGroup = OutputMixerGroup;
    }

    
    public void TakeDamage(int Damage)
    {
        Audio.clip = DummyHitClip;
        Audio.Play();

        DamageText.text = Damage.ToString();

    }
}
