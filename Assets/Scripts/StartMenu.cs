using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Load the game scene using its build index (should be 1)
        SceneManager.LoadScene(1);  // 1 is the index of the game scene in Build Settings
    }
} 