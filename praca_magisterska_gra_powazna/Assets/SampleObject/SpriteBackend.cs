using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpriteBackend : MonoBehaviour
{
    public static bool isMoveDownAnimationTriggered = false;
    public static GameObject selectedNeuronElement;
    public static bool isgoBackToViewModeButtonActive = false;
    public static bool isBackToViewModeAnimationTriggered = false;

    public GameObject jadro_neuronu;

    public event Action<GameObject> OnChildClicked;

    public void ChildEntered(GameObject child)
    {
        // Wywo³anie zdarzenia OnChildClicked
        OnChildClicked?.Invoke(child);


        if (child == jadro_neuronu)
        {
            p.r("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! JADRO !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }

    }
}