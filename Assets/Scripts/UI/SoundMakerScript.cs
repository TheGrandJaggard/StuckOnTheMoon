using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SoundMakerScript : MonoBehaviour
{
    public AudioClip[] Clips;

    public void PlayClip(string WhatClip)
    {
        AudioSource Audio = GetComponent<AudioSource>();

        for (int i = 0; i < Clips.Length; i++)
        {
            if (Clips[i].name == WhatClip)
            {
                Audio.clip = Clips[i];
                Audio.Play();
            }
        }
    }
}
