using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpriteBackend : MonoBehaviour
{
    public event Action<GameObject> neuronElementEventHandler;

    public GameObject spriteViewModePosition;
    public GameObject spriteTextModePosition;
    public GameObject spriteCenralPoint;

    private Color originalSpriteElementColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    private bool isNeuronInTextMode = false;
    public GameObject buttonBackToViewMode;
    private GameObject currentChild;
    private GameObject currentChildTextContainer;

    List<GameObject> neuronSpriteChildren = new List<GameObject>();

    private void Start()
    {
        buttonBackToViewMode.SetActive(false);
    }

    public void addNeuronElementToList(GameObject child)
    {
        neuronSpriteChildren.Add(child);
    }

    public void neuronElementMouseDown(GameObject child, GameObject childTextContainer)
    {
        neuronElementEventHandler?.Invoke(child);
        currentChild = child;
        currentChildTextContainer = childTextContainer;
        moveNeuronDown();
    }

    public void neuronElementMouseEnter(GameObject child)
    {
        if (!isNeuronInTextMode)
        {
            neuronElementEventHandler?.Invoke(child);
            setTriggeredElementColor(child);
        }
    }

    public void neuronElementMouseExit(GameObject child)
    {
        if (!isNeuronInTextMode)
        {
            neuronElementEventHandler?.Invoke(child);
            setDefaultColor(child);
        }
    }

    public void moveNeuronDown()
    {
        spriteCenralPoint.transform.position = spriteTextModePosition.transform.position;
        setTextModeColor();
        isNeuronInTextMode = true;
        setDefaultColor(currentChild);
        buttonBackToViewMode.SetActive(true);
        currentChildTextContainer.SetActive(true);
    }

    public void moveNeuronUp()
    {
        spriteCenralPoint.transform.position = spriteViewModePosition.transform.position;
        isNeuronInTextMode = false;
        setDefaultColor();
        buttonBackToViewMode.SetActive(false);
        currentChildTextContainer.SetActive(false);
    }

    public void setTriggeredElementColor(GameObject child)
    {
        child.GetComponent<SpriteRenderer>().color = new Color(5.0f, 0.0f, 0.0f, 0.9f);
    }

    public void setTextModeColor()
    {
        Color helpColorSave = originalSpriteElementColor;
        helpColorSave.a = 0.2f;

        foreach (GameObject child in neuronSpriteChildren)
        {
            child.GetComponent<SpriteRenderer>().color = helpColorSave;
        }
    }

    public void setDefaultColor(GameObject child)
    {
        child.GetComponent<SpriteRenderer>().color = originalSpriteElementColor;
    }

    public void setDefaultColor()
    {
        foreach (GameObject child in neuronSpriteChildren)
        {
            child.GetComponent<SpriteRenderer>().color = originalSpriteElementColor;
        }
    }
}