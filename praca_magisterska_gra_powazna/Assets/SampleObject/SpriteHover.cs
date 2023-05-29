using UnityEngine;

public class SpriteHover : MonoBehaviour
{
    public GameObject neuron_akson;
    public GameObject neuron_oslonka_mielinowa;
    public GameObject neuron_oslonka_schwanna;

    private SpriteRenderer spriteRenderer;
    private Color originalSpriteColor;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSpriteColor = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1.0f);
    }

    private void OnMouseEnter()
    {
        if(gameObject == neuron_akson)
        {
            p.r("AKSON");
        }
        else if (gameObject == neuron_oslonka_mielinowa)
        {
            p.r("OSLONKA MIELINOWA");
        }
        else if (gameObject == neuron_oslonka_schwanna)
        {
            p.r("OSLONKA SCHWANNA");
        }
        spriteRenderer.color = Color.red;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = originalSpriteColor;
    }
}
