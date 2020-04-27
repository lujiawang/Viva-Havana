using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour
{
    public Animator animator;
    private string sceneName;

    private GameObject loading;
    private GameObject menu;

    void Start()
    {
        menu = transform.GetChild(0).gameObject;
        loading = transform.GetChild(1).gameObject.transform.GetChild(1).gameObject;

        GameObject.FindGameObjectWithTag("Player").transform.position = Vector3.zero;
        GameObject.FindGameObjectWithTag("Player").transform.rotation = Quaternion.identity;

    }

    public void Fade()
    {
        string current = SceneManager.GetActiveScene().name;
        if (!current.Equals(sceneName))
        {
            menu.SetActive(false);
            animator.SetTrigger("FadeOut");
            loading.SetActive(true);
        }
    }

    public void loadScene()
    {
        loading.GetComponent<TextMeshProUGUI>().text = "loading...";

        SceneManager.LoadScene(sceneName);

    }

    public void ToPlaza()
    {
        sceneName = "Plaza de la Catedral";
        Fade();
    }
    public void ToRestaurant()
    {
        sceneName = "Restaurant - La Bodeguita Del Medio";
        Fade();
    }
    public void ToShoppingMall()
    {
        sceneName = "Shopping Street";
        Fade();
    }

    public void ToBeach()
    {
        sceneName = "Beach";
        Fade();
    }

    public void ToCredit()
    {
        sceneName = "Credit";
        Fade();
    }


}
