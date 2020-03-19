using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*This script will eventually be replaced by a UI menu*/
public class SceneSwitcher : MonoBehaviour
{
    public Animator animator;
    private string sceneName;

    public void Fade()
    {
        string current = SceneManager.GetActiveScene().name;
        if (!current.Equals(sceneName))
        {
            animator.SetTrigger("FadeOut");
        }
    }

    public void loadScene()
    {
        SceneManager.LoadScene(sceneName);
        GameObject.FindGameObjectWithTag("Player").transform.position = Vector3.zero;
        GameObject.FindGameObjectWithTag("Player").transform.rotation = Quaternion.identity;
        
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
        sceneName = "Shopping";
        Fade();
    }


}
