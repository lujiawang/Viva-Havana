using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameDescription : MonoBehaviour
{
    public GameObject Text;
    private GameObject Avatar;

    public float trigger = 10f;

    private void Start()
    {
        Avatar = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Text.transform.position, Avatar.transform.position) < trigger)
        {
            Text.SetActive(true);
        }
    }
}
