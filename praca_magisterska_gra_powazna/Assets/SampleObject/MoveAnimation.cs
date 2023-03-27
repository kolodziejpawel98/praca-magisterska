using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    public bool isSideLeftAnimationOn = false;
    public bool isCentralizationAnimationOn = false;
    public Transform brainPositionForDisplayingText;
    public Transform cameraCentralPoint;
    public Transform brainContainer;
    private float movementSpeed = 6.5f;
    private Vector3 vectorCentreOfLobeToCentreOfBrain;

    public BrainDescriptionText brainDescriptionText;
    public MouseHover mouseHover;
    Vector3 brainScaleHelp;

    private void Start()
    {
        setTextVisibility(false);
    }
    void Update()
    {
        vectorCentreOfLobeToCentreOfBrain = brainContainer.transform.position - transform.position;

        if (isSideLeftAnimationOn)
        {
            moveBrainLeft();
        }
        if (BrainCentralization.isCentralizationMoveOn)
        {
            disableSideLeftAnimation();
            scaleDownBrain();
        }
    }

    public void setTextVisibility(bool isTextVisible)
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
        brainContainer.transform.position = Vector3.Lerp(
                brainContainer.transform.position, 
                brainPositionForDisplayingText.transform.position + vectorCentreOfLobeToCentreOfBrain, 
                Time.deltaTime * movementSpeed);

        if ((brainPositionForDisplayingText.transform.position.x + vectorCentreOfLobeToCentreOfBrain.x) 
            - brainContainer.transform.position.x < 0.3f)
        {
            mouseHover.activateColor();
            setTextVisibility(true);
            scaleUpBrain();
        }
        else
        {
            mouseHover.defaultColor();
            setTextVisibility(false);
        }
    }

    //public void brainCentralizationMovement()
    //{
    //    print("centre");
    //    brainContainer.transform.position = Vector3.Lerp(
    //        brainContainer.transform.position,
    //        cameraCentralPoint.transform.position,
    //        Time.deltaTime * movementSpeed);

    //    setTextVisibility(false);
    //}

    public void enableBrainCentralization()
    {
        isCentralizationAnimationOn = true;
        isSideLeftAnimationOn = false;
    }

    public void enableSideLeftAnimation()
    {
        //isCentralizationAnimationOn = false;
        isSideLeftAnimationOn = true;
    }

    public void disableSideLeftAnimation()
    {
        isSideLeftAnimationOn = false;
        setTextVisibility(false);
    }

    void scaleUpBrain()
    {
        brainScaleHelp = brainContainer.transform.localScale;
        brainContainer.transform.localScale = Vector3.Lerp(brainContainer.transform.localScale, brainContainer.transform.localScale * 35.0f, 1.5f * Time.deltaTime);
    }

    void scaleDownBrain()
    {
        brainContainer.transform.localScale = brainScaleHelp;
    }

    void print(string text)
    {
        UnityEngine.Debug.Log(text);
    }

}