using UnityEngine;

public class SpriteHover : MonoBehaviour
{
    public GameObject neuronElementTextContainer;
    private SpriteBackend spriteBackend;

    private void Start()
    {
        spriteBackend = GetComponentInParent<SpriteBackend>();
        spriteBackend.addNeuronElementToList(gameObject);
    }

    private void OnMouseDown()
    {
        spriteBackend.neuronElementMouseDown(gameObject, neuronElementTextContainer);
    }

    private void OnMouseEnter()
    {
        spriteBackend.neuronElementMouseEnter(gameObject);
    }

    private void OnMouseExit()
    {
        spriteBackend.neuronElementMouseExit(gameObject);
    }
}
