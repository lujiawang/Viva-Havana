using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public Camera cam;
    public float quitTime = 40f;
    void Update()
    {
        cam.transform.position = Vector3.zero;
        if (Time.time > quitTime)
            Application.Quit();
    }

   
}
