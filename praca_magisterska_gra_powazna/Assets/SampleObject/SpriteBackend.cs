using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBackend : MonoBehaviour
{
    public static bool isMoveDownAnimationTriggered = false;
    public static GameObject selectedNeuronElement;
    public static bool isgoBackToViewModeButtonActive = false;
    public static bool isBackToViewModeAnimationTriggered = false;
    
    public void goBackToViewSpriteMode()
    {
        isgoBackToViewModeButtonActive = false;
        isBackToViewModeAnimationTriggered = true;
    }
}
