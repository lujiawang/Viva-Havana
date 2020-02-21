using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SwapVideo : MonoBehaviour
{
	private VideoPlayer vp;

	public VideoClip[] clips;

    // Start is called before the first frame update
    void Start()
    {
		vp = GetComponent<VideoPlayer>();
		vp.clip = clips[0];
		print(vp.clip.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
