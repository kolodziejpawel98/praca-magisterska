using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class GrabRotation : MonoBehaviour
{
    public BrainRotation brainRotation;
    float pressTime;
    float pressDuration = 0.0f;

    void OnMouseDown()
    {
        //pressTime = Time.time;
        UnityEngine.Debug.Log("Object clicked!");
    }

    private void Update()
    {
        pressDuration += 0.02f;
    }

    void OnMouseDrag()
    {
        
        if(pressDuration < 0.1f)
        {
            pressDuration = 0.0f;
        }
        else
        {
            UnityEngine.Debug.Log("!!!!!!");
            brainRotation.isBrainRotating = true;
            pressDuration = 0.0f;
        }
        
    }


    //float pressTime;
    //float pressDuration;

    //void OnMouseDown()
    //{
    //    pressTime = Time.time;
    //}

    //void OnMouseUp()
    //{
    //    float releaseTime = Time.time;
    //    pressDuration = releaseTime - pressTime;
    //    //UnityEngine.Debug.Log("Mouse press duration = " + pressDuration + " seconds.");
    //}

    ////private void Update()
    ////{
    ////    if(pressDuration >= 0.1f)
    ////    {
    ////        UnityEngine.Debug.Log("!!!!!!!!!!!!!!");
    ////        brainRotation.isBrainRotating = true;
    ////        pressDuration = 0.0f;
    ////    }
    ////}
    //void OnMouseDrag()
    //{
    //    if (pressDuration >= 0.1f)
    //    {
    //        UnityEngine.Debug.Log("!!!!!!!!!!!!!!");
    //        brainRotation.isBrainRotating = true;
    //        pressDuration = 0.0f;
    //    }
    //    //brainRotation.isBrainRotating = true;
    //}
}
