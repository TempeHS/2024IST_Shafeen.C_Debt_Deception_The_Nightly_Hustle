using System.Collections;
using UnityEngine;
using UnityEngine.UI; // Make sure to include this for Text


public class CoinManager : MonoBehaviour
{
    public int coinCount;            // Tracks the player's coin count
    public Text coinText;            // UI element to display the coin count
    public GameObject door;          // The door GameObject to be destroyed
    private bool doorDestroyed;      // Tracks if the door has been destroyed


    // Start is called before the first frame update
    void Start()
    {
        // Optional: Initialize your variables here, if needed
        doorDestroyed = false; // Make sure the door hasn't been destroyed initially
        coinCount = 0;         // Make sure coinCount starts at 0 or the appropriate number
    }


    // Update is called once per frame
    void Update()
    {
        // Update the coin text to display current coin count
        coinText.text = ": " + coinCount.ToString();


        // Check if coin count reaches or exceeds 24, and if door is not destroyed
        if (coinCount >= 24 && !doorDestroyed)
        {
            Debug.Log("Coin count is 24 or more. Destroying the door.");
            doorDestroyed = true;
           
            if (door != null) // Ensure the door is assigned
            {
                Debug.Log("Door GameObject found, proceeding to destroy.");
                Destroy(door);
            }
            else
            {
                Debug.LogError("Door GameObject is not assigned in the Inspector!");
            }
        }
    }


    // Call this function when a coin is collected
    public void CollectCoin()
    {
        coinCount++; // Increment the coin count
        Debug.Log("Coin collected. Current coin count: " + coinCount);
    }
}
