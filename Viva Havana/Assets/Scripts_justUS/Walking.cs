using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * Author: Lujia Wang
 * This script simply control the moving straight behavior,
 * which can be applied to walking animators, cars, etc.
 * 
 **/

public class Walking : MonoBehaviour
{
    public float speed = 0.02f;
    public float longestDistance = 30f;
    private float pedometer = 0f;

    private float rotateX = 0f;
    public float rotateY = 180f;
    private float rotateZ = 0f; //Usually just rotate around y-axis

    void Update()
    {
        pedometer += Mathf.Abs(speed);
        transform.Translate(new Vector3(0f,0f,speed), Space.Self);

        if (pedometer >= longestDistance)
        {
            transform.Rotate(new Vector3(rotateX,rotateY,rotateZ));
            pedometer = 0f;
        }
    }
    
}
