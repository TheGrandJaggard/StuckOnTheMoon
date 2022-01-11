using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath EnemyAI;
    public Transform PlayerTransform;
    private Vector3 PlayerPos;
    public bool PointAtPlayer;

    void Update()
    {
        if (PointAtPlayer == true)
        {
            Transform SelfTransform = gameObject.GetComponent<Transform>();
            PlayerPos = new Vector3(
                PlayerTransform.position.x,
                PlayerTransform.position.y,
                PlayerTransform.position.z
                );
            Vector2 Direction = new Vector2(
                PlayerPos.x - SelfTransform.position.x,
                PlayerPos.y - SelfTransform.position.y
                );
            SelfTransform.right = Direction;
        }
        else
        {
            SpriteRenderer SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            if (EnemyAI.desiredVelocity.x >= 0.01f)
            {
                SpriteRenderer.flipX = true;
            }
            else if (EnemyAI.desiredVelocity.x <= 0.01f)
            {
                SpriteRenderer.flipX = false;
            }
        }
    }
}
