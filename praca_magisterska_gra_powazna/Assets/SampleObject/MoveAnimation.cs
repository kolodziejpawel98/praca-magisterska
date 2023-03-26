using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    public bool isSideLeftAnimationOn = false;
    public Transform brainPositionForDisplayingText;
    public Transform cameraCentralPoint;
    public Transform brainContainer;
    private float movementSpeed = 6.5f;
    private Vector3 vectorCentreOfLobeToCentreOfBrain;
    public bool imChoosenLobe = false;

    public BrainDescriptionText brainDescriptionText;


    // Update is called once per frame
    void Update()
    {
        vectorCentreOfLobeToCentreOfBrain = brainContainer.transform.position - transform.position;
        //UnityEngine.Debug.Log("xd = " + vectorCentreOfLobeToCentreOfBrain);
        setTextVisibility(false);

        if (isSideLeftAnimationOn)
        {
            moveBrainLeft();
        }
        else
        {
            if (imChoosenLobe)
            {
                brainCentralizationMovement();
            }
            
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
        //transform.position = Vector3.Lerp(transform.position, brainPositionForDisplayingText.transform.position, Time.deltaTime * movementSpeed);

        //if(brainPositionForDisplayingText.transform.position.x - transform.position.x < 0.3f)
        //{
        //    setTextVisibility(true);
        //}
        //else
        //{
        //    setTextVisibility(false);
        //}

        brainContainer.transform.position = Vector3.Lerp(
                brainContainer.transform.position, 
                brainPositionForDisplayingText.transform.position + vectorCentreOfLobeToCentreOfBrain, 
                Time.deltaTime * movementSpeed);

        if (brainPositionForDisplayingText.transform.position.x - brainContainer.transform.position.x < 0.3f)
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
        //transform.position = Vector3.Lerp(transform.position, cameraCentralPoint.transform.position, Time.deltaTime * movementSpeed);
        //setTextVisibility(false);
        brainContainer.transform.position = Vector3.Lerp(
            brainContainer.transform.position,
            cameraCentralPoint.transform.position,
            Time.deltaTime * movementSpeed);

        setTextVisibility(false);
    }
}