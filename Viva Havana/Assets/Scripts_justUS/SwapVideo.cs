using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;

/*Author: Lujia Wang*/
/*This script simply switch the video clips*/
public class SwapVideo : MonoBehaviour
{
	private VideoPlayer vp;

	public VideoClip[] clips;
	private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
		vp = GetComponent<VideoPlayer>();
		vp.clip = clips[index];
    }

    
    public void Swapping()
    {

		index++;
		index %= clips.Length;
		vp = GetComponent<VideoPlayer>();
		vp.clip = clips[index];
        
    }
}
