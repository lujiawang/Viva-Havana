using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBip : MonoBehaviour
{

	private GameObject player;
    private bool beep;
	public AudioClip SoundToPlay;
	public float Volume;
	AudioSource audio;
	
	// Start is called before the first frame update
    void Start()
    {
		audio = GetComponent<AudioSource>();
        beep = false;
	}

	// Update is called once per frame
	void Update()
    {
		player = GameObject.FindWithTag("Player");
		object source = GetComponent<AudioSource>();
		if (!beep && Vector3.Distance(player.transform.position, GameObject.Find("Car").transform.position) <= 15)
		{
			audio.PlayOneShot(SoundToPlay, Volume);
            beep = true;
		}
        if (beep && Vector3.Distance(player.transform.position, GameObject.Find("Car").transform.position) > 15)
        {
            beep = false;
        }
    }
}
