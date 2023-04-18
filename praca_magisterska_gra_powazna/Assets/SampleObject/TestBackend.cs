using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestBackend : MonoBehaviour
{
    static public int score = 0;

    //private void Update()
    //{
    //    UnityEngine.Debug.Log("score = " + score);
    //}

    public void increaseScore()
    {
        score++;
    }
}
