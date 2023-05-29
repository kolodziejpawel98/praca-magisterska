using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBackend : MonoBehaviour
{
    public static bool isSpriteInClickableMode = true;
    public static bool isMoveDownAnimationTriggered = false;
    public static GameObject selectedNeuronElement; //!!!!!!

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


    private void Update()
    {
        if (isMoveDownAnimationTriggered)
        {
            moveSpriteDown();
        }
    }

    public void moveSpriteDown()
    {
        if (isSpriteInClickableMode)
        {
            gameObject.transform.position = Vector2.Lerp(
                            gameObject.transform.position,
                            new Vector3(1.13f, -7.58f, -0.64f),
                            20.2f * Time.deltaTime
                        );
            isSpriteInClickableMode = false;
        }

    }

    //public GameObject checkNeuronPart()
    //{
    //    if (selectedNeuronElement == neuron_akson)
    //    {
    //        return neuron_akson;
    //    }
    //    else if (selectedNeuronElement == neuron_cialo_komorki)
    //    {
    //        return neuron_cialo_komorki;
    //    }
    //    else if (selectedNeuronElement == neuron_dendryty)
    //    {
    //        return neuron_dendryty;
    //    }
    //    else if (selectedNeuronElement == neuron_drzewko_koncowe)
    //    {
    //        return neuron_drzewko_koncowe;
    //    }
    //    else if (selectedNeuronElement == neuron_jadro)
    //    {
    //        return neuron_jadro;
    //    }
    //    else if (selectedNeuronElement == neuron_kolbki_synaptyczne)
    //    {
    //        return neuron_kolbki_synaptyczne;
    //    }
    //    else if (selectedNeuronElement == neuron_odgalezienie_boczne)
    //    {
    //        return neuron_odgalezienie_boczne;
    //    }
    //    else if (selectedNeuronElement == neuron_odgalezienie_koncowe)
    //    {
    //        return neuron_odgalezienie_koncowe;
    //    }
    //    else if (selectedNeuronElement == neuron_oslonka_mielinowa)
    //    {
    //        return neuron_oslonka_mielinowa;
    //    }
    //    else if (selectedNeuronElement == neuron_oslonka_schwanna)
    //    {
    //        return neuron_oslonka_schwanna;
    //    }
    //    else if(selectedNeuronElement == neuron_wezly_ranviera)
    //    {
    //        return neuron_wezly_ranviera;
    //    }
    //}

}
