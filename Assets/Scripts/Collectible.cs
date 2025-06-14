using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    public int pointValue = 50;  
    public float rotationSpeed = 100f;  
    public GameObject collectEffect;  
    public TextMeshProUGUI collectibleText;

    void Start()
    {
        // Set higher point value for special collectibles
        if (gameObject.CompareTag("Special Collectible"))
        {
            pointValue = 100;  // Special collectibles are worth 100 points
        }
    }

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

            // Update collectible text
            if (collectibleText != null)
            {
                collectibleText.text = "Sphere Collected! +" + pointValue + " points";
                // You might want to add a coroutine here to make the text disappear after a few seconds
                StartCoroutine(HideTextAfterDelay(2f));
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

    private System.Collections.IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (collectibleText != null)
        {
            collectibleText.text = "";  // Clear the text after delay
        }
    }
} 