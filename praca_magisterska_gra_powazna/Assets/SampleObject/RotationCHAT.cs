using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCHAT : MonoBehaviour
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
            UnityEngine.Debug.Log("x = " + mouseX);
            UnityEngine.Debug.Log("y = " + mouseY);

            centerOfRotation.transform.Rotate(Vector3.down, mouseX * rotationSpeed * Time.deltaTime, Space.World);
            centerOfRotation.transform.Rotate(Vector3.right, mouseY * rotationSpeed * Time.deltaTime, Space.World);
        }
        isBrainRotating = false;
    }
}
