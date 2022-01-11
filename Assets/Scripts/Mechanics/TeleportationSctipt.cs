using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationSctipt : MonoBehaviour
{
    private bool PlayerIsHere;
    public Transform TeleportLocation;
    public Transform GameObjectToMove;
    

    void OnTriggerEnter2D(Collider2D other)
    { PlayerIsHere = true; }

    void OnTriggerExit2D(Collider2D other)
    { PlayerIsHere = false; }

    void Update()
    {
        if (PlayerIsHere == true && Input.GetButtonDown("Submit"))
        {
            //Debug.Log("is here and did press Submit");
            MoveGameObject();
        }
    }

    public void MoveGameObject()
    {
        GameObjectToMove.transform.position = TeleportLocation.transform.position;  //new Vector3(PosX, PosY, 0);
    }
}