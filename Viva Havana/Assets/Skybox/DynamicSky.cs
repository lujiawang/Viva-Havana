using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Lujia Wang */
/* Animating the skybox*/

public class DynamicSky : MonoBehaviour
{

    public float RotateSpeed = 1.2f;

    public float SwitchTime = 5f;
    //public float LerpSpeed = 1.2f;
    public Material startMat;
    public Material endMat;

    void Start()
    {
        RenderSettings.skybox = startMat;
    }


    void Update()
    {
        //RenderSettings.skybox.Lerp(startMat, endMat, Time.time * LerpSpeed); 
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);

        //if(Time.time >= SwitchTime)
        //{
            //RenderSettings.skybox = endMat;
        //}

        //DynamicGI.UpdateEnvironment();
    }
}
