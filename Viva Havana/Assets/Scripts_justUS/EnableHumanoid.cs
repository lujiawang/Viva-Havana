using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnableHumanoid : MonoBehaviour
{
    public static EnableHumanoid Instance;
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("RegularCam") != null)
        {
            Destroy(gameObject);
        }

    }
    public void GetMenu()
    {       
        GameObject menu = GameObject.FindGameObjectWithTag("Menu");
        menu.GetComponent<EnableCanvas>().Enable();

    }

}
