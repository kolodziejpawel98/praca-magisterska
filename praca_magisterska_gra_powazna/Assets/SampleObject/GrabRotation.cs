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

    void OnMouseDrag()
    {
        isDragCounter++;
        if(isDragCounter > dragTrigger)
        {
            brainRotation.isBrainRotating = true;
        }
    }

    private void OnMouseUp()
    {
        if(isDragCounter <= dragTrigger)
        {
            moveAnimation.isSideLeftAnimationOn = true;
        }
        isDragCounter = 0;
    }
}
