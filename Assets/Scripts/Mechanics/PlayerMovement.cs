using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D Controller;
    public float RunSpeed = 40f;
    private float Movement;
    private bool Jump = false;
    private bool Crouch = false;
    public Animator Animator;

    private AudioSource PlayerAudio;
    public AudioClip Footsteps;

    void OnStartJumping()
    {
        Jump = true;
    }

    void OnStopJumping()
    {
        Jump = false;
    }

    void OnStartCrouching()
    {
        Crouch = true;
    }

    void OnStopCrouching()
    {
        Crouch = false;
    }

    public void OnMove(InputValue input)
    {
        PlayerAudio = GetComponent<AudioSource>();

        if (PlayerAudio.isPlaying == false)
        {
            PlayerAudio.clip = Footsteps;
            PlayerAudio.Play();
        }

        if (input.Get<float>() <= 0.1f && input.Get<float>() >= -0.1f && PlayerAudio.clip.name == Footsteps.name)
        {
            PlayerAudio.Stop();
        }

        Movement = input.Get<float>() * RunSpeed;
        Animator.SetFloat("Speed", Mathf.Abs(Movement));
    }

    void FixedUpdate()
    {
        Controller.Move(Movement * Time.fixedDeltaTime, Crouch, Jump);
    }

}
