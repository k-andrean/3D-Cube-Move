using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody Rb;
    public float forwardforce = 2000f;
    public float sideforce = 500;

    // Update is called once per frame
   void FixedUpdate()
    {
        // Adding force to game object
        Rb.AddForce(0, 0, forwardforce * Time.deltaTime); 

    }
}
