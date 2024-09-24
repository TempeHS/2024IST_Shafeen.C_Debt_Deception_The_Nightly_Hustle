using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Damage1 : MonoBehaviour
{
    public float damage = 10f;
   


    private void OnCollisionEnter2D(Collision2D other)
    {
        // Debug to check if the collision is detected
        Debug.Log("Enemy collided with something.");


        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enemy collided with the Player.");


            PlayerHealth1 playerHealth = other.gameObject.GetComponent<PlayerHealth1>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage((int)damage);
                Debug.Log("Player took damage: " + damage);
            }
            else
            {
                Debug.Log("PlayerHealth1 component not found on Player.");
            }
        }
    }
}

