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
    public static bool enableddd = true;

    void OnMouseDrag()
    {
        if (enableddd)
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
        if (enableddd)
        {
            if (isDragCounter <= dragTrigger)
            {
                //enableddd = false;
                //leftSideInactiveMode = true;
                moveAnimation.enableSideLeftAnimation();
            }
            isDragCounter = 0;
        }
     
    }
}
