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

    void Start()
    {
        newSphereColorHELP = newSphereColor;
        sphereRenderer = sphere.GetComponent<Renderer>();
    }

    private void OnMouseOver()
    {
        UnityEngine.Debug.Log("OnMouseOver");
        ActivateColor();
    }

    private void OnMouseExit()
    {
        UnityEngine.Debug.Log("OnMouseExit");
        DefaultColor();
    }

    private void ActivateColor()
    {
        newSphereColor = newSphereColorHELP;
        sphereRenderer.material.SetColor("_Color", newSphereColor);
    }

    private void DefaultColor()
    {
        newSphereColor = new Color(0.3f, 0.3f, 0.3f, 1f);
        sphereRenderer.material.SetColor("_Color", newSphereColor);
    }
}
