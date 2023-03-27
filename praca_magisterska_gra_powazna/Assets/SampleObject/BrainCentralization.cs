using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainCentralization : MonoBehaviour
{
    public static bool isCentralizationMoveOn = false;
    public Transform cameraCentralPoint;
    private float movementSpeed = 6.5f;

    // Update is called once per frame
    void Update()
    {
        if (isCentralizationMoveOn)
        {
            brainCentralizationMovement();
        }
    }

    public void tickCentralizationFLag()
    {
        if (isCentralizationMoveOn)
        {
            isCentralizationMoveOn = false;
        }
        else
        {
            isCentralizationMoveOn = true;
        }

    }

    public void brainCentralizationMovement()
    {
        print("centre");
        transform.position = Vector3.Lerp(
            transform.position,
            cameraCentralPoint.transform.position,
            Time.deltaTime * movementSpeed);

        //settextvisibility(false);
    }
}
