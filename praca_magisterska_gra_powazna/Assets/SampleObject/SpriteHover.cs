using UnityEngine;

public class SpriteHover : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color originalSpriteColor;
    public GameObject spriteContainer;
    public GameObject spriteTextModePosition;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSpriteColor = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1.0f);
    }

    private void OnMouseEnter()
    {
        //if (SpriteBackend.isSpriteInClickableMode)
        //{
            spriteRenderer.color = new Color(5.0f, 0.0f, 0.0f, 0.9f);
        //}
    }

    private void OnMouseExit()
    {
        //if (SpriteBackend.isSpriteInClickableMode)
        //{
            spriteRenderer.color = originalSpriteColor;
        //}
    }

    private void OnMouseDown()
    {
        SpriteBackend.selectedNeuronElement = gameObject;
        SpriteBackend.isMoveDownAnimationTriggered = true;
        //moveSpriteDown();
    }
}
