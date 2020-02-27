using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCanvas : MonoBehaviour
{
    public GameObject gameObject;
    public bool active = false;
    public AudioSource Audio;

    public void Enable()
    {
        active = !active;
        gameObject.SetActive(active);

        if (active)
            Audio.Play();
    }
}
