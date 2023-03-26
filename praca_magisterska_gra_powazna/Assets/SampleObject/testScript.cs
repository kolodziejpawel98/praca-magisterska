using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public bool flag = false;
    void Update()
    {
        if (flag)
        {
            transform.position = new Vector3(5.0f, 5.0f, 1.0f);
        }
        else
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}
