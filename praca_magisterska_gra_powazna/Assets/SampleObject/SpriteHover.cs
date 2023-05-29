using UnityEngine;

public class SpriteHover : MonoBehaviour
{
    private Color originalSpriteElementColor;
    public GameObject spriteContainer;
    public GameObject spriteTextModePosition;
    private bool spriteElementSelected = false; //zmienna dzieki ktorej klikniety element jako jedyny sie nie zaswieci na czerwono po kliknieciu
    public GameObject goBackToViewModeButton;

    private void Start()
    {
        goBackToViewModeButton.gameObject.SetActive(false);

        originalSpriteElementColor = new Color(
                GetComponent<SpriteRenderer>().color.r,
                GetComponent<SpriteRenderer>().color.g,
                GetComponent<SpriteRenderer>().color.b, 
                1.0f
            );
    }

    private void Update()
    {
        if (SpriteBackend.isMoveDownAnimationTriggered && !spriteElementSelected)
        {
            setTextModeColor(); //ustawienie wszystkim (poza kliknietym) elementom ciemnego koloru
        }
    }

    private void OnMouseEnter()
    {
        if (!SpriteBackend.isMoveDownAnimationTriggered)
        {
            setTriggeredElementColor();
        }
    }

    private void OnMouseExit()
    {
        if (!SpriteBackend.isMoveDownAnimationTriggered)
        {
            setDefaultColor();
        }
    }

    private void OnMouseDown()
    {
        if (!SpriteBackend.isMoveDownAnimationTriggered)
        {
            SpriteBackend.selectedNeuronElement = gameObject;
            SpriteBackend.isMoveDownAnimationTriggered = true;
            moveSpriteDown();
            setDefaultColor(); //dzieki temu klikniety element sie nie bedzie swiecil, a w update() zasiweca sie wszystkie inne
            spriteElementSelected = true;
            goBackToViewModeButton.gameObject.SetActive(true);
        }
    }

    public void moveSpriteDown()
    {
        spriteContainer.transform.position = Vector2.Lerp(
                        spriteContainer.transform.position,
                        spriteTextModePosition.transform.position,
                        100.2f * Time.deltaTime
                    );

    }

    public void setTriggeredElementColor()
    {
        GetComponent<SpriteRenderer>().color = new Color(5.0f, 0.0f, 0.0f, 0.9f);
    }

    public void setTextModeColor()
    {
        Color helpColorSave = originalSpriteElementColor;
        helpColorSave.a = 0.2f;
        GetComponent<SpriteRenderer>().color = helpColorSave;
    }

    public void setDefaultColor()
    {
        GetComponent<SpriteRenderer>().color = originalSpriteElementColor;
    }

    public void goBackToViewMode()
    {
        goBackToViewModeButton.gameObject.SetActive(false);
    }
}
