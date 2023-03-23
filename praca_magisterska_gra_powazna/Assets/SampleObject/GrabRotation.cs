using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class GrabRotation : MonoBehaviour
{
    public BrainRotation brainRotation;

    void OnMouseDrag()
    {
        brainRotation.isBrainRotating = true;
    }
}
