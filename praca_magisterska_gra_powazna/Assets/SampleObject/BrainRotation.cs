using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainRotation : MonoBehaviour
{

    public float rotationSpeed = 1000f;
    public bool isBrainRotating = false;
    public Transform centerOfRotation;

    void Update()
    {
        if (isBrainRotating)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            transform.RotateAround(centerOfRotation.position, Vector3.down, mouseX * rotationSpeed * Time.deltaTime);
            transform.RotateAround(centerOfRotation.position, Vector3.right, mouseY * rotationSpeed * Time.deltaTime);
        }
        isBrainRotating = false;
    }

    public void resetVariables()
    {
        rotationSpeed = 10f;
        isBrainRotating = false;
    }
}
