using UnityEngine;

public class SprawdzanieCollidera : MonoBehaviour
{
    private void OnMouseEnter()
    {
        // Kod wykonywany, gdy mysz najedzie na obiekt
        Debug.Log("Najechano na obiekt!");
    }

    private void OnMouseExit()
    {
        // Kod wykonywany, gdy mysz opu�ci obiekt
        Debug.Log("Opuszczono obiekt!");
    }
}
