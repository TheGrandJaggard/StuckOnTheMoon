using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private GameObject ExplosionPrefab;
    private float Speed;
    private float GravityScale;
    private int Damage;
    private bool CanPierce;
    private Sprite Sprite;
    private Vector2 Scale;

    public void SetVariables(GameObject BulletExplosionPrefab, float BulletSpeed, float BulletGravityScale, int BulletDamage, Vector2 BulletScale, bool BulletCanPierce, Sprite BulletSprite)
    {
        Scale = BulletScale;
        ExplosionPrefab = BulletExplosionPrefab;
        Speed = BulletSpeed;
        GravityScale = BulletGravityScale;
        Damage = BulletDamage;
        CanPierce = BulletCanPierce;
        Sprite = BulletSprite;

        MyAwake();
    }

    private void MyAwake()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * Speed*80);
        GetComponent<Rigidbody2D>().gravityScale = GravityScale;
        GetComponent<SpriteRenderer>().sprite = Sprite;
        transform.localScale = new Vector3(Scale.x, Scale.y, 0);
    }

    void OnTriggerEnter2D(Collider2D Info)
    {
        EnemyScript EnemyScript = Info.GetComponent<EnemyScript>();

        if (ExplosionPrefab != null)
        {
            GameObject ExplosionObject = Instantiate(ExplosionPrefab, transform.position, transform.rotation);
            ExplosionScript ExplosionScript = ExplosionObject.GetComponent<ExplosionScript>();
            ExplosionScript.BlowUp(Damage);
        }
        else if (EnemyScript != null)
        {
            EnemyScript.TakeDamage(Damage);
        }
            
        if (CanPierce == false || Info.tag == "Obstacle")
            Destroy(gameObject);
    }
}
