using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

}
