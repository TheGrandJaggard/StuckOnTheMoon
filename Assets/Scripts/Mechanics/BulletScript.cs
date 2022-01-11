using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D rb;
    public int Damage;
    public bool CanPierce;
    public GameObject ExplosionPrefab;
    public bool BlowUp;

    void Awake()
    {
        rb.AddForce(transform.right * Speed);
    }

    void OnTriggerEnter2D(Collider2D Info)
    {
        EnemyScript EnemyScript = Info.GetComponent<EnemyScript>();

        if (BlowUp == true)
        {
            GameObject ExplosionObject = Instantiate(ExplosionPrefab, transform.position, transform.rotation);
            ExplosionScript ExplosionScript = ExplosionObject.GetComponent<ExplosionScript>();
            ExplosionScript.BlowUp(Damage);
        }
        else if (EnemyScript != null)
        {
            EnemyScript.TakeDamage(Damage);
        }
            
        if (CanPierce == false)
            Destroy(gameObject);
        else if (Info.tag == "Obstacle")
            Destroy(gameObject);
    }
}
