using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBell : MonoBehaviour
{
    private new AudioSource audio;
    private float time;

    void Awake()
    {
        time = 0f;
        audio = GetComponent<AudioSource>();
        if (Time.time <= 10)
            audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 60f ){
            audio.Play();
            time = 0;
        }
    }
}
