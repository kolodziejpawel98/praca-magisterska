using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    public bool isSideLeftAnimationOn = false;
    public Transform brainPositionForDisplayingText;
    public Transform cameraCentralPoint;
    private float movementSpeed = 6.5f;

    public BrainDescriptionText brainDescriptionText;

    // Update is called once per frame
    void Update()
    {
        //TODO
        // * change scale during movement to left
        // * add click & press diff
        // * add scaling part of brain during movement to left & enable color

        setTextVisibility(false);

        if (isSideLeftAnimationOn)
        {
            moveBrainLeft();
        }
        else
        {
            brainCentralizationMovement();
        }
    }

    void setTextVisibility(bool isTextVisible)
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
        transform.position = Vector3.Lerp(transform.position, brainPositionForDisplayingText.transform.position, Time.deltaTime * movementSpeed);
        
        if(brainPositionForDisplayingText.transform.position.x - transform.position.x < 0.3f)
        {
            setTextVisibility(true);
        }
        else
        {
            setTextVisibility(false);
        }
    }

    void brainCentralizationMovement()
    {
        transform.position = Vector3.Lerp(transform.position, cameraCentralPoint.transform.position, Time.deltaTime * movementSpeed);
        setTextVisibility(false);
    }
}