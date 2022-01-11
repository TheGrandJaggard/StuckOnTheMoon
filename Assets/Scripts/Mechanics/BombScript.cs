using UnityEngine;

public class BombScript : MonoBehaviour
{
    private int DamageToDo;

    public void BlowUp(int Damage)
    {
        DamageToDo = Damage;
        Invoke("SelfDestruct", 1);
        Debug.Log("BlowUp : " + Damage.ToString() + " : " + DamageToDo.ToString());
    }

    void OnTriggerEnter2D(Collider2D Info)
    {
        EnemyScript EnemyScript = Info.GetComponent<EnemyScript>();

        Debug.Log("I hit " + Info.name);

        if (EnemyScript != null)
        {
            Debug.Log("I hit an enemy");
            EnemyScript.TakeDamage(DamageToDo);
        }
    }

    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
