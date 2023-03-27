using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainCentralization : MonoBehaviour
{
    public static bool isCentralizationMoveOn = false;
    public Transform cameraCentralPoint;
    private float movementSpeed = 6.5f;
    private const float distanceBrainToCentreTriggeringFlag = 0.3f;

    // Update is called once per frame
    void Update()
    {
        if (isCentralizationMoveOn)
        {
            brainCentralizationMovement();
        }

        if (cameraCentralPoint.transform.position.x - transform.position.x < distanceBrainToCentreTriggeringFlag)
        {
            isCentralizationMoveOn = false;
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
        transform.position = Vector3.Lerp(
            transform.position,
            cameraCentralPoint.transform.position,
            Time.deltaTime * movementSpeed);
    }
}
