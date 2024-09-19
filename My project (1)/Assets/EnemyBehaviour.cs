using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitPoints = 5;
    public HealthBarBehaviour HealthBar;
    void Start()
    {
        Hitpoints = MaxHitPoints;
        HealthBar.SetHealth(Hitpoints, MaxHitPoints);
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        HealthBar.SetHealth(Hitpoints, MaxHitPoints);

        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
