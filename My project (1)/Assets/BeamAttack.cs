using UnityEngine;

public class BeamAttack : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        var enemy = collision.collider.GetComponent<EnemyBehaviour>();
        if(enemy)
        {
            enemy.TakeHit(1);
        }

        Destroy(gameObject);
    }

}
