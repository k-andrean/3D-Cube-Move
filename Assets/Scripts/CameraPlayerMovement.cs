using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerMovement : MonoBehaviour
{
    public GameObject playercube;

    private Vector3 offset;
    void Start()
    {
        offset = transform.position - playercube.transform.position;
    }

    void LateUpdate()
    {
        transform.position = playercube.transform.position + offset;
    }
}
