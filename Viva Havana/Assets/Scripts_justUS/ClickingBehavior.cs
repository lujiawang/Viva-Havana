using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Passer;
using UnityEngine.Events;
using System;

public class ClickingBehavior : MonoBehaviour
{
    private bool clicked = false;

    public Transform fingerTipLeft;
    public Transform fingerTipRight;

    private float distance;
    public float threshold;

    public Transform[] buttons;
    public UnityEvent[] OnClick;

   

    void Update()
    {
        for (int i=0; i < buttons.Length; i++) { 

            distance = Math.Min(Vector3.Distance(fingerTipLeft.position, buttons[i].position), Vector3.Distance(fingerTipRight.position, buttons[i].position));
            if (distance <= threshold && !clicked)
            {
                clicked = true;
                OnClick[i].Invoke();
            }
            else if (distance > threshold)
            {
                clicked = false;
            }
        }
        
    }
}
