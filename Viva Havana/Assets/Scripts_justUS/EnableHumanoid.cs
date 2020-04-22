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
        else if (Instance != this || SceneManager.GetActiveScene().name.Equals("credit"))
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
