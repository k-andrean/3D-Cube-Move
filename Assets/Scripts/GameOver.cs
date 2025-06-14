using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collisionInfo)


    {
        if (collisionInfo.collider.tag == "obstacle")
        {

            FindObjectOfType<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }

    }
}
