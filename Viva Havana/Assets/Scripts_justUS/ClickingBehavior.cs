using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Passer;
using UnityEngine.Events;
using System;

public class ClickingBehavior : MonoBehaviour
{
    private bool clicked = false;
    private float time;

    public UnityEvent OnClick;
    private Color origin;
    private Color darker;
    private AudioSource audio;

    private void Awake()
    {
        origin = GetComponent<Renderer>().material.color;
        darker = new Color(origin.r - 0.1f, origin.g - 0.1f, origin.b - 0.1f);
        audio = GetComponent<AudioSource>();

        time = 0;
    }

    void FixedUpdate()
    {
        time += Time.time;
        if (time >= 5 && clicked)
        {
            time = 0;
            clicked = false;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = darker;
        if (!clicked)
        {
            OnClick.Invoke();
            clicked = true;
            audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = origin;
    }
}
