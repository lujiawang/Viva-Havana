using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStop : MonoBehaviour
{
    void OnCollisionEnter (Collision col)
    {
        Debug.Log("Hit " + col.gameObject.name);
    }
    
    
}
