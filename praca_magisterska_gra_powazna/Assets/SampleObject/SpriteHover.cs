using UnityEngine;

public class SpriteHover : MonoBehaviour
{
    private Color originalSpriteElementColor;
    public GameObject spriteContainer;
    public GameObject spriteTextModePosition;
    public GameObject spriteViewModePosition;
    private bool spriteElementSelected = false; //zmienna dzieki ktorej klikniety element jako jedyny sie nie zaswieci na czerwono po kliknieciu
    public GameObject goBackToViewModeButton;
    private bool isSpriteBackToViewMode = false;
    public GameObject neuronElementTextContainer;

    private SpriteBackend spriteBackend;

    private void Start()
    {
        spriteBackend = GetComponentInParent<SpriteBackend>();
        spriteBackend.addNeuronElementToList(gameObject);
    }

    private void OnMouseDown()
    {
        spriteBackend.neuronElementMouseDown(gameObject);
    }

    private void OnMouseEnter()
    {
        spriteBackend.neuronElementMouseEnter(gameObject);
    }

    private void OnMouseExit()
    {
        spriteBackend.neuronElementMouseExit(gameObject);
    }















    //private void Start()
    //{
    //    goBackToViewModeButton.gameObject.SetActive(false);

    //    originalSpriteElementColor = new Color(
    //            GetComponent<SpriteRenderer>().color.r,
    //            GetComponent<SpriteRenderer>().color.g,
    //            GetComponent<SpriteRenderer>().color.b, 
    //            1.0f
    //        );
    //}

    //private void Update()
    //{
    //    if (SpriteBackend.isMoveDownAnimationTriggered && !spriteElementSelected)
    //    {
    //        setTextModeColor(); //ustawienie wszystkim (poza kliknietym) elementom ciemnego koloru
    //    }

    //    if (SpriteBackend.isgoBackToViewModeButtonActive)
    //    {
    //        goBackToViewModeButton.gameObject.SetActive(true);
    //        isSpriteBackToViewMode = true;
    //    }
    //    else
    //    {
    //        goBackToViewModeButton.gameObject.SetActive(false);
    //        neuronElementTextContainer.SetActive(false);
    //        if (isSpriteBackToViewMode) //dzieki temu flaga ustawi siê gdy sprite jest na dole, a to uruchomi za gdy sprite worci na gore
    //        {
    //            setDefaultColor();
    //            isSpriteBackToViewMode = false;
    //            spriteElementSelected = false;
    //        }
    //    }

    //    if (SpriteBackend.isBackToViewModeAnimationTriggered)
    //    {
    //        moveSpriteToViewPosition();
    //        SpriteBackend.isBackToViewModeAnimationTriggered = false;
    //        SpriteBackend.isMoveDownAnimationTriggered = false;  
    //    }
    //}

    //private void OnMouseEnter()
    //{
    //    if (!SpriteBackend.isMoveDownAnimationTriggered)
    //    {
    //        setTriggeredElementColor();
    //    }
    //}

    //private void OnMouseExit()
    //{
    //    if (!SpriteBackend.isMoveDownAnimationTriggered)
    //    {
    //        setDefaultColor();
    //    }
    //}

    //private void OnMouseDown()
    //{
    //    if (!SpriteBackend.isMoveDownAnimationTriggered)
    //    {
    //        SpriteBackend.selectedNeuronElement = gameObject;
    //        SpriteBackend.isMoveDownAnimationTriggered = true;
    //        moveSpriteToTextPosition();
    //        setDefaultColor(); //dzieki temu klikniety element sie nie bedzie swiecil, a w update() zasiweca sie wszystkie inne
    //        spriteElementSelected = true;
    //        SpriteBackend.isgoBackToViewModeButtonActive = true;
    //        neuronElementTextContainer.SetActive(true);
    //    }
    //}

    //public void moveSpriteToTextPosition()
    //{
    //    spriteContainer.transform.position = Vector2.Lerp(
    //                    spriteContainer.transform.position,
    //                    spriteTextModePosition.transform.position,
    //                    100.2f * Time.deltaTime
    //                );

    //}

    //public void moveSpriteToViewPosition()
    //{
    //    spriteContainer.transform.position = Vector2.Lerp(
    //                    spriteContainer.transform.position,
    //                    spriteViewModePosition.transform.position,
    //                    100.2f * Time.deltaTime
    //                );

    //}

    //public void setTriggeredElementColor()
    //{
    //    GetComponent<SpriteRenderer>().color = new Color(5.0f, 0.0f, 0.0f, 0.9f);
    //}

    //public void setTextModeColor()
    //{
    //    Color helpColorSave = originalSpriteElementColor;
    //    helpColorSave.a = 0.2f;
    //    GetComponent<SpriteRenderer>().color = helpColorSave;
    //}

    //public void setDefaultColor()
    //{
    //    GetComponent<SpriteRenderer>().color = originalSpriteElementColor;
    //}
}
