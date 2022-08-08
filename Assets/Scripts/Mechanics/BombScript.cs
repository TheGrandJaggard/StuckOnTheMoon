using UnityEngine;

public class BombScript : MonoBehaviour
{
    private int DamageToDo;

    public void BlowUp(int Damage)
    {
        DamageToDo = Damage;
        Invoke("SelfDestruct", 1);
        //Debug.Log("BlowUp : " + Damage.ToString() + " : " + DamageToDo.ToString());
    }

    void OnTriggerEnter2D(Collider2D Info)
    {
        EnemyScript EnemyScript = Info.GetComponent<EnemyScript>();
        DummyScript DummyScript = Info.GetComponent<DummyScript>();

        //Debug.Log("I hit " + Info.name);

        if (EnemyScript != null)
        {
            //Debug.Log("I hit an Enemy");
            EnemyScript.TakeDamage(DamageToDo);
        }
        
        if (DummyScript != null)
        {
            //Debug.Log("I hit a Dummy");
            DummyScript.TakeDamage(DamageToDo);
        } 
    }

    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
