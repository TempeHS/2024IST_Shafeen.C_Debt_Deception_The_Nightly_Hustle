using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage2 : MonoBehaviour
{
    public playerHealth pHealth;
    public float damage; 
    // Start is called before the first frame update
    void Start()
    {
        pHealth = FindObjectOfType<playerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<playerHealth>().health -= damage;
        }
    }
}