using UnityEngine;

public class SpriteHover : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color originalSpriteColor;
    public GameObject spriteContainer;
    public GameObject spriteTextModePosition;

    public GameObject neuron_akson;
    public GameObject neuron_cialo_komorki;
    public GameObject neuron_dendryty;
    public GameObject neuron_drzewko_koncowe;
    public GameObject neuron_jadro;
    public GameObject neuron_kolbki_synaptyczne;
    public GameObject neuron_odgalezienie_boczne;
    public GameObject neuron_odgalezienie_koncowe;
    public GameObject neuron_oslonka_mielinowa;
    public GameObject neuron_oslonka_schwanna;
    public GameObject neuron_wezly_ranviera;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSpriteColor = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1.0f);
    }

    private void OnMouseEnter()
    {
        spriteRenderer.color = new Color(5.0f, 0.0f, 0.0f, 0.9f);
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = originalSpriteColor;
    }

    private void OnMouseDown()
    {
        checkNeuronPart();
        spriteContainer.transform.position = Vector2.Lerp(
                spriteContainer.transform.position, 
                spriteTextModePosition.transform.position, 
                20.2f * Time.deltaTime
            );

    }

    public void checkNeuronPart()
    {
        if (gameObject == neuron_akson)
        {
            p.r("neuron_akson");
        }
        else if (gameObject == neuron_cialo_komorki)
        {
            p.r("neuron_cialo_komorki");
        }
        else if (gameObject == neuron_dendryty)
        {
            p.r("neuron_dendryty");
        }
        else if (gameObject == neuron_drzewko_koncowe)
        {
            p.r("neuron_drzewko_koncowe");
        }
        else if (gameObject == neuron_jadro)
        {
            p.r("neuron_jadro");
        }
        else if (gameObject == neuron_kolbki_synaptyczne)
        {
            p.r("neuron_kolbki_synaptyczne");
        }
        else if (gameObject == neuron_odgalezienie_boczne)
        {
            p.r("neuron_odgalezienie_boczne");
        }
        else if (gameObject == neuron_odgalezienie_koncowe)
        {
            p.r("neuron_odgalezienie_koncowe");
        }
        else if (gameObject == neuron_oslonka_mielinowa)
        {
            p.r("neuron_oslonka_mielinowa");
        }
        else if (gameObject == neuron_oslonka_schwanna)
        {
            p.r("neuron_oslonka_schwanna");
        }
        else if (gameObject == neuron_wezly_ranviera)
        {
            p.r("neuron_wezly_ranviera");
        }
    }
}
