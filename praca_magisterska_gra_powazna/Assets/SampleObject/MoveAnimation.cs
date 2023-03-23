using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    //centerOfRotation.transform.position
    public bool isSideLeftAnimationOn = false;
    private Vector3 sideLeftBrainPosition = new Vector3(-5.0f, 0.0f, 0.0f);
    private Vector3 centralBrainPoint = new Vector3(0.17f, 0.13f, 1.95f);
    private float movementSpeed = 1.2f;

    private Vector3 cameraViewCentralPosition;

    public BrainDescriptionText brainDescriptionText;
    public bool isTextVisible = false;


    // Update is called once per frame
    void Update()
    {
        changeTextVisibility(isTextVisible);

        if (isSideLeftAnimationOn)
        {
            moveBrainLeft();
        }
        else
        {
            //TODO
            // - brain rotation around same point in zoom mode
            // - move from left position to start position
            // - change left move method (after rotating brain moves to weird point)

            //brainCentralizationMovement();
        }
    }

    void changeTextVisibility(bool isTextVisible)
    {
        if (isTextVisible)
        {
            brainDescriptionText.textContainer.gameObject.SetActive(true);
        }
        else
        {
            brainDescriptionText.textContainer.gameObject.SetActive(false);
        }
    }

    void moveBrainLeft()
    {
        transform.position = Vector3.Lerp(transform.position, sideLeftBrainPosition, Time.deltaTime * movementSpeed);
    }

    void brainCentralizationMovement()
    {
        transform.position = Vector3.Lerp(transform.position, centralBrainPoint, Time.deltaTime * movementSpeed);
    }
}