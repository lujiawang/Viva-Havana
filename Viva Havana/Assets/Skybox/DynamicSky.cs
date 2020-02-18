using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Lujia Wang */
/* Animating the skybox*/

public class DynamicSky : MonoBehaviour
{

    public float RotateSpeed = 1.2f;
    public float ChangingSpeed = 1.0f;
    
    public Material skybox;

    private Color color;
    private float red = 0.5f, green = 0.5f, blue = 0.5f;

    void Start()
    {   //red = 0.5f, green = 0.5f, blue = 0.5f;
        RenderSettings.skybox = skybox;
        RenderSettings.skybox.SetFloat("_Exposure", 1.0f);
        color = new Color(red,green,blue,0.5f);
    }


    void Update()
    {

        RenderSettings.skybox.SetColor("_Tint", color);
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
        
    }
}
