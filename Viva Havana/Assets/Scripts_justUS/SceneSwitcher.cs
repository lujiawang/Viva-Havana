using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*This script will eventually be replaced by a UI menu*/
public class SceneSwitcher : MonoBehaviour
{
    public int sceneNum = 2;
    
    public void SceneSwitch()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        
        SceneManager.LoadScene((current+1) % sceneNum);

        GameObject.FindGameObjectWithTag("Player").transform.position = Vector3.zero;
    }

}
