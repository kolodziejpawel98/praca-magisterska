using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    public bool isSideLeftAnimationOn = false;
    //public bool isCentralizationAnimationOn = false;
    public Transform brainPositionForDisplayingText;
    public Transform cameraCentralPoint;
    public Transform brainContainer;
    private float movementSpeed = 6.5f;
    private Vector3 vectorCentreOfLobeToCentreOfBrain;

    public BrainDescriptionText brainDescriptionText;
    public MouseHover mouseHover;
    public GameObject centralizeBrainButton;
    public GameObject goInsideButton;
    Vector3 brainScaleSave;

    private void Start()
    {
        brainScaleSave = brainContainer.transform.localScale;
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
            centralizationAdditionalActions();
            GrabRotation.isClickingTurnedOn = true;
        }
    }

    public void setTextVisibility(bool isTextVisible)
    {
        if (isTextVisible)
        {
            brainDescriptionText.textContainer.gameObject.SetActive(true);
            centralizeBrainButton.gameObject.SetActive(true);
            goInsideButton.gameObject.SetActive(true);
        }
        else
        {
            brainDescriptionText.textContainer.gameObject.SetActive(false);
            centralizeBrainButton.gameObject.SetActive(false);
            goInsideButton.gameObject.SetActive(false);
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
            GrabRotation.isClickingTurnedOn = false;
        }
    }

    public void enableSideLeftAnimation()
    {
        isSideLeftAnimationOn = true;
    }

    public void disableSideLeftAnimation()
    {
        isSideLeftAnimationOn = false;
        setTextVisibility(false);
    }

    void centralizationAdditionalActions()
    {
        disableSideLeftAnimation();
        scaleDownBrain();
        mouseHover.defaultColor();
    }

    void scaleUpBrain()
    {
        brainContainer.transform.localScale = Vector3.Lerp(brainContainer.transform.localScale, brainContainer.transform.localScale * 235.0f, 0.02f * Time.deltaTime);
    }

    void scaleDownBrain()
    {
        brainContainer.transform.localScale = brainScaleSave;
    }

    void print(string text)
    {
        UnityEngine.Debug.Log(text);
    }

    public void resetVariables()
    {
        movementSpeed = 6.5f;
        brainScaleSave = brainContainer.transform.localScale;
        setTextVisibility(false);
    }

}