using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainRotation : MonoBehaviour
{

    public float rotationSpeed = 1000f;
    public bool isBrainRotating = false;
    public Transform centerOfRotation;

    // Update is called once per frame
    void Update()
    {
        if (isBrainRotating)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            transform.RotateAround(centerOfRotation.position, Vector3.up, mouseX * rotationSpeed * Time.deltaTime);
            transform.RotateAround(centerOfRotation.position, Vector3.right, mouseY * rotationSpeed * Time.deltaTime);
        }
        isBrainRotating = false;
    }
}
