using UnityEngine;

public class SpriteHover : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color originalSpriteColor;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSpriteColor = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1.0f);
    }

    private void OnMouseEnter()
    {
        spriteRenderer.color = Color.red;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = originalSpriteColor;
    }
}
