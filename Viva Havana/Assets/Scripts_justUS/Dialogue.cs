using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] lines;
    private int count;
    public GameObject next;

    void Start()
    {
        count = 0;
    }

    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 faceTo = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        transform.LookAt(faceTo);
    }
    
    public void NextLine()
    {
        if (count != lines.Length)
        {
            text.text = lines[count];
            count++;
        }
        else
        {
            gameObject.SetActive(false);
            if (next != null)
                next.gameObject.SetActive(true);
        }
    }
}
