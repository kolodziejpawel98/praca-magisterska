using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class GrabRotation : MonoBehaviour
{
    public BrainRotation brainRotation;
    public MoveAnimation moveAnimation;
    private int isDragCounter = 0;
    private const int dragTrigger = 15;
    public bool leftSideInactiveMode = false;
    public static bool isClickingTurnedOn = true;

    void OnMouseDrag()
    {
        if (isClickingTurnedOn)
        {
            isDragCounter++;
            if (isDragCounter > dragTrigger)
            {
                brainRotation.isBrainRotating = true;
            }
        }
        
    }

    private void OnMouseUp()
    {
        if (isClickingTurnedOn)
        {
            if (isDragCounter <= dragTrigger)
            {
                moveAnimation.enableSideLeftAnimation();
            }
            isDragCounter = 0;
        }
     
    }
}
