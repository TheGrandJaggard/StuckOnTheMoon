using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePadScript : MonoBehaviour
{
    [Range(1, 100)] [SerializeField] private int AddForce;
    void OnTriggerEnter2D(Collider2D Info)
    {
        CharacterController2D PlayerController = Info.GetComponent<CharacterController2D>();
        Rigidbody2D Rigidbody2D = Info.GetComponent<Rigidbody2D>();

        if (PlayerController != null)
        {
            PlayerController.AddJumpForce(AddForce);
        }
        else if (Rigidbody2D != null)
        {
            Debug.Log("Rigidbody Instead");
            Rigidbody2D.AddForce(new Vector2 (0, AddForce * 50));
        }
        
    }
}
