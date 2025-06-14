using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  // Add TextMeshPro namespace

public class GameManager : MonoBehaviour
{
    bool gamehasEnded = false;
    public int score = 0;
    public TextMeshProUGUI scoreText;  
    public GameObject LevelCompletePanel;
    public TextMeshProUGUI completeText;  // New text for level completion message

    void Start()
    {
        UpdateScoreText();
    
        if (LevelCompletePanel != null)
        {
            LevelCompletePanel.SetActive(false);
            completeText.gameObject.SetActive(false);
        }
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    public void GameOver()
    {
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Restart();
            void Restart()
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void LevelComplete()
    {
        // Show the level complete panel
        if (LevelCompletePanel != null)
        {
            LevelCompletePanel.SetActive(true);
        }

        // Update completion text
        if (completeText != null)
        {   
            completeText.text = "Level Complete!\nFinal Score: " + score;
            completeText.gameObject.SetActive(true);
        }

        // Disable player movement
        PlayerMovement playerMovement = FindObjectOfType<PlayerMovement>();
        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }

        // Pause the game
        Time.timeScale = 0f;
    }
}
