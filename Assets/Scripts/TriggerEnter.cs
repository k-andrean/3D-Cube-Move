using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnter : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

            if (other.tag == "Player")
            {
                FindObjectOfType<GameManager>().LevelComplete();
                Player.SetActive(false);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Load Next Level in Build Setting.


            }

    }
 
}
