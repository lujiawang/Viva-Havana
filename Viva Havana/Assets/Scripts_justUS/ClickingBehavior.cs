using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Passer;
using UnityEngine.Events;
using System;

public class ClickingBehavior : MonoBehaviour
{
    private bool clicked = false;

    public UnityEvent OnClick;
    private Color origin;
    private Color darker;
    private AudioSource audio;

    private void Awake()
    {
        origin = GetComponent<Renderer>().material.color;
        darker = new Color(origin.r - 0.1f, origin.g - 0.1f, origin.b - 0.1f);
        audio = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = darker;
        OnClick.Invoke();
        print("clicked");
        audio.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = origin;
    }
}
