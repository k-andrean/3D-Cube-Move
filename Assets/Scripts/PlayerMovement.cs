using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rb; //Player's Rigidbody is used to add force towards it.
    public float forwardForce = 1000f;
    public float sideForce = 500f;
    public float BackwardForce = -200f;

    // Update is called once per frame
    public void FixedUpdate()
    {

        Rb.AddForce(0, 0, forwardForce * Time.deltaTime); //0 and 0 is for X and Y axises
        if (Input.GetKey("d"))
        {
            Rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            Rb.AddForce(0, 0, BackwardForce * Time.deltaTime, ForceMode.VelocityChange); //Backward force 
        }

        if (Input.GetKey("w"))
        {
            Rb.AddForce(0, 0, 200f);//Here we can't add forwardForce variable because it will be a very high speed then.
        }

        if (Rb.position.y < -1.6f) // Check if player has fallen below -1.6 units
        {
            FindObjectOfType<GameManager>().GameOver();
        }

      
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
