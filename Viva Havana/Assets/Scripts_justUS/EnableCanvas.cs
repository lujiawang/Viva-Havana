using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCanvas : MonoBehaviour
{
    public GameObject canvas;
    public bool active = false;
    public AudioSource audio;
    

    void Update()
    {
        Transform humanoid = GameObject.FindGameObjectWithTag("Player").transform;
        transform.position = humanoid.position;
        transform.rotation = humanoid.rotation;
    }

    public void Enable()
    {
        active = !active;       
        canvas.SetActive(active);
        audio.Play();
        Debug.Log(audio.clip.name);
        
    }
}
