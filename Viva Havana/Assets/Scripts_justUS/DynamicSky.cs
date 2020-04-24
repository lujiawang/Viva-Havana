using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Lujia Wang */
/* Animating the skybox*/

public class DynamicSky : MonoBehaviour
{

    public float RotateSpeed = 1.2f;
    public float duration = 60f;
        
    //public Material skybox;


    private float ChangingSpeed = 1.0f;

    private Color color;
    private float red = 0.5f, green = 0.5f, blue = 0.5f, alpha = 0.5f;
    private float redSpeed, greenSpeed, blueSpeed, alphaSpeed;
    public float SunsetRed = 0.95f, SunsetGreen = 0.53f, SunsetBlue = 0.45f, SunsetAlpha = 0.3f;

    private float exposure = 1.0f;
    private float exposureSpeed;

    void Start()
    {
        CalculateSpeed();
        //RenderSettings.skybox = skybox;
        RenderSettings.skybox.SetFloat("_Exposure", 1.0f);
        color = new Color(red, green, blue, alpha);
        RenderSettings.skybox.SetColor("_Tint", color);
    }

    // default 30 fps
    void Update()
    {
        //rotation
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);

        /*//color
        if (red <= SunsetRed && green <= SunsetGreen && blue >= SunsetBlue && alpha >= SunsetAlpha)
        {
            red -= redSpeed;
            green -= greenSpeed;
            blue -= blueSpeed;
            alpha -= alphaSpeed;
            color = new Color(red,green,blue,alpha);
            RenderSettings.skybox.SetColor("_Tint", color);
        }*/

        //darkness
        if (exposure >= 0.5f)
        {
            exposure -= exposureSpeed;
            RenderSettings.skybox.SetFloat("_Exposure", exposure);
        }
    }

    void CalculateSpeed()
    {
        float totalFrame = duration * 30f;

        //color
        redSpeed = (0.5f - SunsetRed) / totalFrame;
        greenSpeed = (0.5f - SunsetGreen) / totalFrame;
        blueSpeed = (0.5f - SunsetBlue) / totalFrame;
        alphaSpeed = (0.5f - SunsetAlpha) / totalFrame;
        
        //exposure
        exposureSpeed = (1.0f - 0.5f) / totalFrame;
    }
}
