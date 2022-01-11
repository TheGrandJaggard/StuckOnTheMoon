using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    private int DamageToDo;
    public int HowLongToExplodeFor;


    public void BlowUp(int Damage)
    {
        DamageToDo = Damage;
        Invoke("SelfDestruct", HowLongToExplodeFor);
    }

    void OnTriggerEnter2D(Collider2D Info)
    {
        EnemyScript EnemyScript = Info.GetComponent<EnemyScript>();

        //Debug.Log("I hit " + Info.name);

        if (EnemyScript != null)
        {
            //Debug.Log("I hit an enemy");
            EnemyScript.TakeDamage(DamageToDo);
        }
    }

    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
