using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    [SerializeField]
    private Color newSphereColor;
    [SerializeField]
    private GameObject sphere;
    private Renderer sphereRenderer;

    void Start()
    {
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
        newSphereColor = new Color(0.2f, 0.2f, 0.2f, 1f);
        sphereRenderer.material.SetColor("_Color", newSphereColor);
    }

    private void DefaultColor()
    {
        newSphereColor = new Color(1f, 0f, 0f, 1f);
        sphereRenderer.material.SetColor("_Color", newSphereColor);
    }
}
