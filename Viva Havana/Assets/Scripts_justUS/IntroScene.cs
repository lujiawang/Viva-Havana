using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


/*This script will eventually be replaced by a UI menu*/
public class IntroScene : MonoBehaviour
{
    private string sceneName;

    private GameObject loading;
    private GameObject intro;

    private bool load;

    void Start()
    {
        loading = transform.GetChild(0).gameObject.transform.GetChild(1).gameObject;
        intro = transform.GetChild(0).gameObject.transform.GetChild(2).gameObject;
        

        load = false;
    }

    public void Fade()
    {
        string current = SceneManager.GetActiveScene().name;
        if (!current.Equals(sceneName))
        {
            intro.SetActive(false);
            loading.SetActive(true);
        }
    }

    public void loadScene()
    {
        loading.GetComponent<TextMeshProUGUI>().text = "loading...";

        SceneManager.LoadScene("Plaza de la Catedral");
        GameObject.FindGameObjectWithTag("Player").transform.position = Vector3.zero;
        GameObject.FindGameObjectWithTag("Player").transform.rotation = Quaternion.identity;

    }

    void Update()
    {
        if (Time.time > 10f && !load)
        {
            Fade();
            load = true;
            loadScene();
        }
    }
    



}
