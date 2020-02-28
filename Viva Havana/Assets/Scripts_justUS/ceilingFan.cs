using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ceilingFan : MonoBehaviour
{

    public GameObject fan;
    public GameObject center;
    // Start is called before the first frame update
    void Start()
    {
        fan = GameObject.Find("rotateFans");
        center = GameObject.Find("center");
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.transform.position, Vector3.up, 90*Time.deltaTime);
    }
}
