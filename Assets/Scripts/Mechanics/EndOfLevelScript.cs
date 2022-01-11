using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndOfLevelScript : MonoBehaviour
{
    public GameObject EndOfLevelPanel;
    public TMP_Text EndOfLevelText;
    public string CongratulationsText;


    void OnTriggerEnter2D(Collider2D Info)
    {
        CharacterController2D PlayerController = Info.GetComponent<CharacterController2D>();

        if (PlayerController != null)
        {
            EndOfLevelPanel.SetActive(true);
            EndOfLevelText.text = CongratulationsText;
        }
    }
}
