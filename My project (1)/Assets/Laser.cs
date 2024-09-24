using UnityEngine;

public class Laser : MonoBehaviour
{
    // This function gets called when the laser's collider enters another collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object the laser collided with is tagged as "Enemy"
        if (other.CompareTag("Enemy"))
        {
            // Destroy the enemy object
            Destroy(other.gameObject);
        }
    }
}
