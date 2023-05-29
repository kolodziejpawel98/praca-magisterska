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
        if (SpriteBackend.isSpriteInClickableMode)
        {
            spriteRenderer.color = new Color(5.0f, 0.0f, 0.0f, 0.9f);
        }
    }

    private void OnMouseExit()
    {
        if (SpriteBackend.isSpriteInClickableMode)
        {
            spriteRenderer.color = originalSpriteColor;
        }
    }

    private void OnMouseDown()
    {
        p.r(checkNeuronPart().ToString());
        moveSpriteDown();
    }

    public void moveSpriteDown()
    {
        if (SpriteBackend.isSpriteInClickableMode)
        {
            spriteContainer.transform.position = Vector2.Lerp(
                            spriteContainer.transform.position,
                            spriteTextModePosition.transform.position,
                            20.2f * Time.deltaTime
                        );
            spriteRenderer.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            SpriteBackend.isSpriteInClickableMode = false;
        }
        
    }

    public GameObject checkNeuronPart()
    {
        if (gameObject == neuron_akson)
        {
            return neuron_akson;
        }
        else if (gameObject == neuron_cialo_komorki)
        {
            return neuron_cialo_komorki;
        }
        else if (gameObject == neuron_dendryty)
        {
            return neuron_dendryty;
        }
        else if (gameObject == neuron_drzewko_koncowe)
        {
            return neuron_drzewko_koncowe;
        }
        else if (gameObject == neuron_jadro)
        {
            return neuron_jadro;
        }
        else if (gameObject == neuron_kolbki_synaptyczne)
        {
            return neuron_kolbki_synaptyczne;
        }
        else if (gameObject == neuron_odgalezienie_boczne)
        {
            return neuron_odgalezienie_boczne;
        }
        else if (gameObject == neuron_odgalezienie_koncowe)
        {
            return neuron_odgalezienie_koncowe;
        }
        else if (gameObject == neuron_oslonka_mielinowa)
        {
            return neuron_oslonka_mielinowa;
        }
        else if (gameObject == neuron_oslonka_schwanna)
        {
            return neuron_oslonka_schwanna;
        }
        else
        {
            return neuron_wezly_ranviera;
        }
    }
}
