using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCanvas : MonoBehaviour
{
    public GameObject canvas;
    public bool active = false;
    public AudioSource Audio;

    void Update()
    {
        //if(OVRInput.GetDown(OVRInput.Button.))
        if (OVRInput.Get(OVRInput.Button.One)){
            //Audio.Play();
            Enable();
        }
    }

    public void Enable()
    {
        Audio.Play();
        active = !active;       
        canvas.SetActive(active);
        
    }
}
