using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void SceneSwitch(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        GameObject.FindGameObjectWithTag("Player").transform.position = Vector3.zero;
    }

}
