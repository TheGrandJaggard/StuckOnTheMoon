using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    SpriteRenderer MySpriteRenderer;
    Collider2D MyCollider;
    Color MyColor;
    public float Alpha = 0.5f;

    void Start()
    {
        MySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MyCollider = gameObject.GetComponent<Collider2D>();
        MyColor = MySpriteRenderer.color;
    }

    public void Toggle(bool On)
    {
        if (On == true)
        {
            MyColor = new Color(MyColor[0], MyColor[1], MyColor[2], 1);
        }
        else
        {
            MyColor = new Color(MyColor[0], MyColor[1], MyColor[2], Alpha);
        }
        MyCollider.enabled = On;
        MySpriteRenderer.color = MyColor;
    }
}
