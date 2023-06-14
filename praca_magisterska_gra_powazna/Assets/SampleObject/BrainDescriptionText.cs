using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainDescriptionText : MonoBehaviour
{
    public BrainDescriptionText textContainer;

    public List<GameObject> slideImages = new List<GameObject>();
    public List<GameObject> slideTexts = new List<GameObject> ();

    public int currentSlideIndex = 0;

    private void Start()
    {
        foreach (GameObject image in slideImages)
        {
            image.SetActive(false);
        }
        
        foreach (GameObject text in slideTexts)
        {
            text.SetActive(false);
        }
    }

    private void Update()
    {
        if(slideImages.Count > 0)
        {
            slideImages[currentSlideIndex].SetActive(true);
            slideTexts[currentSlideIndex].SetActive(true);
        }
    }

    public void nextSlide()
    {
        if(currentSlideIndex < slideImages.Count - 1)
        {
            slideImages[currentSlideIndex].SetActive(false);
            slideTexts[currentSlideIndex].SetActive(false);
            currentSlideIndex++;
        }
    }

    public void previousSlide()
    {
        if(currentSlideIndex > 0)
        {
            slideImages[currentSlideIndex].SetActive(false);
            slideTexts[currentSlideIndex].SetActive(false);
            currentSlideIndex--;
        }
    }

}
