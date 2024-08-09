using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    public GameObject virtualCam;

    private void OnTriggerEnter2D(Collide2D other)
    {
        if(other.CompareTag("Player"))
    }
}
