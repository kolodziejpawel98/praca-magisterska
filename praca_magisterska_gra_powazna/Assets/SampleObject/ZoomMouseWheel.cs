using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomMouseWheel : MonoBehaviour
{
    private float zoomSpeed = 0.5f;
    private float maxZoomOut = 0.5f;
    private float maxZoomIn = 1.5f;
    private float zoom;

    // Update is called once per frame
    void Update()
    {
        zoom = Input.GetAxis("Mouse ScrollWheel");
        transform.localScale += new Vector3(zoom, zoom, zoom) * zoomSpeed;

        if(transform.localScale.x < maxZoomOut)
        {
            transform.localScale = new Vector3(maxZoomOut, maxZoomOut, maxZoomOut);
        }
        else if (transform.localScale.x > maxZoomIn)
        {
            transform.localScale = new Vector3(maxZoomIn, maxZoomIn, maxZoomIn);
        }
    }
}
