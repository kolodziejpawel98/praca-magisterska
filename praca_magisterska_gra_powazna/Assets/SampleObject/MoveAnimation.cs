using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    public bool isAnimationOn = false;
    private Vector3 textBrainPosition = new Vector3(-5.0f, 0.0f, 0.0f);
    private Vector3 slowDownTrigger = new Vector3(-3.0f, 0.0f, 0.0f);
    private Vector3 startPoint = new Vector3(-1.7f, 0.0f, 0.0f);

    // Update is called once per frame
    void Update()
    {
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

            UnityEngine.Debug.Log("position = " + transform.position);
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