using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public float speed = 0.02f;
    public float longestDistance = 30f;

    private float pedometer = 0f;
    void Update()
    {
        pedometer += speed;
        transform.Translate(new Vector3(0f,0f,speed),Space.Self);

        if (pedometer >= longestDistance)
        {
            transform.Rotate(new Vector3(0f,180f,0f));
            pedometer = 0f;
        }
    }
    
}
