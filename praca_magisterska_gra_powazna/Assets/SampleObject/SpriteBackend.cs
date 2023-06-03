using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpriteBackend : MonoBehaviour
{
    public GameObject neuronAkson;
    public GameObject neuronCialoKomorki;
    public GameObject neuronDendryty;
    public GameObject neuronDrzewkoKoncowe;
    public GameObject neuronJadro;
    public GameObject neuronKolbkiSynaptyczne;
    public GameObject neuronOdgalezienieBoczne;
    public GameObject neuronOdgalezienieKoncowe;
    public GameObject neuronOslonkaMielinowa;
    public GameObject neuronOslonkaSchwanna;
    public GameObject neuronWezlyRanviera;

    public event Action<GameObject> neuronElementEventHandler;

    public GameObject spriteViewModePosition;
    public GameObject spriteTextModePosition;
    public GameObject spriteCenralPoint;

    private Color originalSpriteElementColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    private bool isNeuronInTextMode = false;

    List<GameObject> neuronSpriteChildren = new List<GameObject>();

    public void addNeuronElementToList(GameObject child)
    {
        neuronSpriteChildren.Add(child);
    }

    public void neuronElementMouseDown(GameObject child)
    {
        neuronElementEventHandler?.Invoke(child);
        moveNeuronDown();
        setTextModeColor();
        isNeuronInTextMode = true;
        setDefaultColor(child);
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

    public GameObject getNeuronElement(GameObject element)
    {
        if(element == neuronAkson)
        {
            return neuronAkson;
        }
        else if (element == neuronCialoKomorki)
        {
            return neuronCialoKomorki;
        }
        else if (element == neuronDendryty)
        {
            return neuronDendryty;
        }
        else if (element == neuronDrzewkoKoncowe)
        {
            return neuronDrzewkoKoncowe;
        }
        else if (element == neuronJadro)
        {
            return neuronJadro;
        }
        else if (element == neuronKolbkiSynaptyczne)
        {
            return neuronKolbkiSynaptyczne;
        }
        else if (element == neuronOdgalezienieBoczne)
        {
            return neuronOdgalezienieBoczne;
        }
        else if (element == neuronOdgalezienieKoncowe)
        {
            return neuronOdgalezienieKoncowe;
        }
        else if (element == neuronOslonkaMielinowa)
        {
            return neuronOslonkaMielinowa;
        }
        else if (element == neuronOslonkaSchwanna)
        {
            return neuronOslonkaSchwanna;
        }
        else
        {
            return neuronWezlyRanviera;
        }
    }
}