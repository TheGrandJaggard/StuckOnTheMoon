using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]

public class MusicScript : MonoBehaviour
{

    public AudioMixerGroup OutputMixerGroup;
    private AudioSource Audio;
    public AudioClip[] AllClips;
    private AudioClip CurrentClip;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.outputAudioMixerGroup = OutputMixerGroup;
    }


    void Update()
    {
        
    }
}
