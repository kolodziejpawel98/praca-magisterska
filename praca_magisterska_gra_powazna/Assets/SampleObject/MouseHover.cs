using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    [SerializeField]
    private Color newSphereColor;
    private Color newSphereColorHELP;
    [SerializeField]
    private GameObject sphere;
    private Renderer sphereRenderer;
    //public GrabRotation grabRotation;

    void Start()
    {
        newSphereColorHELP = newSphereColor;
        sphereRenderer = sphere.GetComponent<Renderer>();
    }

    private void OnMouseOver()
    {
        if (GrabRotation.isClickingTurnedOn)
        {
            activateColor();
        }
    }

    private void OnMouseExit()
    {
        if (GrabRotation.isClickingTurnedOn)
        {
            defaultColor();
        }
    }

    public void activateColor()
    {
        newSphereColor = newSphereColorHELP;
        sphereRenderer.material.SetColor("_Color", newSphereColor);
    }

    public void defaultColor()
    {
        newSphereColor = new Color(0.6f, 0.6f, 0.6f, 1f);
        sphereRenderer.material.SetColor("_Color", newSphereColor);
    }

    //public void disabledColor()
    //{
    //    newSphereColor = new Color(0.0f, 0.0f, 0.0f, 1f);
    //    sphereRenderer.material.SetColor("_Color", newSphereColor);
    //}
}
