using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int pointValue = 1;  // Points gained when collecting this item
    public float rotationSpeed = 100f;  // Speed at which the collectible rotates
    public GameObject collectEffect;  // Optional particle effect when collected

    void Update()
    {
        // Rotate the collectible to make it more visible and attractive
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Add points to the game manager
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.AddScore(pointValue);
            }

            // Play collection effect if assigned
            if (collectEffect != null)
            {
                Instantiate(collectEffect, transform.position, Quaternion.identity);
            }

            // Destroy the collectible
            Destroy(gameObject);
        }
    }
} 