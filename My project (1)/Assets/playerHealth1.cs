using UnityEngine;


public class PlayerHealth1 : MonoBehaviour
{
    public int health = 100; // Initial player health
    public Transform respawnPoint;
    private bool isDead = false;


    void Update()
    {
        if (health <= 0 && !isDead)
        {
            Die();
        }
    }


    void Die()
    {
        isDead = true;
        Debug.Log("Player died. Respawning...");
        Respawn();
    }


    void Respawn()
    {
        transform.position = respawnPoint.position;
        health = 100; // Reset health after respawn
        isDead = false;
    }


    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0) health = 0;


        Debug.Log("Player took damage. Current health: " + health);
    }
}

