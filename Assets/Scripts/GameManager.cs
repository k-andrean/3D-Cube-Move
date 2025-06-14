using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  // Add TextMeshPro namespace

public class GameManager : MonoBehaviour
{
    bool gamehasEnded = false;
    public int score = 0;
    public TextMeshProUGUI scoreText;  // Changed to TextMeshProUGUI

    void Start()
    {
        UpdateScoreText();
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
}
