using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    public bool isAnimationOn = false;
    private Vector3 textBrainPosition = new Vector3(-5.0f, 0.0f, 0.0f);
    private Vector3 slowDownTrigger = new Vector3(-3.0f, 0.0f, 0.0f);
    private Vector3 startPoint = new Vector3(-1.7f, 0.0f, 0.0f);

    public BrainDescriptionText brainDescriptionText;
    public bool textOnOff = true;

    // Update is called once per frame
    void Update()
    {
        //UnityEngine.Debug.Log("center = " + renderer.bounds.center);

        if (textOnOff)
        {
            brainDescriptionText.textContainer.gameObject.SetActive(true);
        }
        else
        {
            brainDescriptionText.textContainer.gameObject.SetActive(false);
        }

        if (isAnimationOn)
        {
            if (transform.position.x >= slowDownTrigger.x)
            {
                transform.position += new Vector3(-0.05f, 0.0f, 0.0f);
            }

            if (transform.position.x >= textBrainPosition.x && transform.position.x < slowDownTrigger.x)
            {
                transform.position += new Vector3(-0.03f, 0.0f, 0.0f);
            }
        }
        else
        {
            if (transform.position.x <= startPoint.x)
            {
                transform.position += new Vector3(0.05f, 0.0f, 0.0f);
            }
        }
    }
}