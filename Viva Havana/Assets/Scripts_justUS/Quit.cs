using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public Camera cam;
    public float quitTime = 40f;
    private float time;
    void Start()
    {
        time = 0f;
    }

    void Update()
    {
        time += Time.deltaTime;
        cam.transform.position = Vector3.zero;
        if (time > quitTime)
            Application.Quit();
    }

   
}
