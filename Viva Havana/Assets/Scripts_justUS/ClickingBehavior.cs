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

    public Transform buttons;
    public UnityEvent OnClick;
       

    /*void Update()
    {
            distance = Math.Min(Vector3.Distance(fingerTipLeft.position, buttons.position), Vector3.Distance(fingerTipRight.position, buttons.position));
            if (distance <= threshold && !clicked)
            {
                clicked = true;
                OnClick.Invoke();
            }
            else if (distance > threshold)
            {
                clicked = false;
            }        
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        OnClick.Invoke();
        print("clicked");
    }
}
