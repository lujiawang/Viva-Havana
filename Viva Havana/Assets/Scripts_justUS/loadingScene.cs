using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class loadingScene : MonoBehaviour
{
    private TextMeshProUGUI text;
    private int count = 0;
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 0.5f)
        {
            time = 0;
            if(count == 0)
            {
                text.text = "loading";
                count++;
            }
            else if(count == 1)
            {
                text.text = "loading.";
                count++;
            }
            else if (count == 2)
            {
                text.text = "loading..";
                count++;
            }
            else if (count == 3)
            {
                text.text = "loading...";
                count = 0;
            }
        }

    }
}
