using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class GrabRotation : MonoBehaviour
{
    public RotationCHAT rotationCHAT;

    void OnMouseDrag()
    {
        rotationCHAT.isBrainRotating = true;
    }
}
