using UnityEngine;


public class SpikeBehavior : MonoBehaviour
{
    // Reference to the restart menu
    public GameObject restartMenu;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Deactivate the player GameObject or disable player movement (optional)
            collision.gameObject.SetActive(false);


            // Activate the restart menu
            restartMenu.SetActive(true);
            Debug.Log("Player destroyed. Showing restart menu.");
        }
    }
}

