using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*This script will eventually be replaced by a UI menu*/
public class SceneSwitcher : MonoBehaviour
{
    public int PlazaNum = 0;
    public int RestaurantNum = 1;
    public GameObject plaza;
    public GameObject rest;
    public Material originMat;
    public Material darkerMat;
    public void ToPlaza()
    {
        Material mat = plaza.GetComponent<Renderer>().material;
        mat = darkerMat;
        print("palza");
        SceneManager.LoadScene(PlazaNum);
        GameObject.FindGameObjectWithTag("Player").transform.position = Vector3.zero;
        mat = originMat;
    }
    public void ToRestaurant()
    {
        Material mat = rest.GetComponent<Renderer>().material;
        mat = darkerMat;
        print("res");
        SceneManager.LoadScene(RestaurantNum);
        GameObject.FindGameObjectWithTag("Player").transform.position = Vector3.zero;
        mat = originMat;
    }

}
