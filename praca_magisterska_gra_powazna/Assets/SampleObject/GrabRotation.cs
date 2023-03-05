using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class GrabRotation : MonoBehaviour
{
    
    [SerializeField] float rotationSpeed = 2000f;
    bool dragging = false;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void OnMouseDrag()
    {
        UnityEngine.Debug.Log("!!!!!");
        dragging = true;
    }

    void Update()
    {
        if (dragging)
        {
            UnityEngine.Debug.Log("!!!!!");
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }
     


    void FixedUpdate()
    {
        
        if (dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
        }
    }
}
