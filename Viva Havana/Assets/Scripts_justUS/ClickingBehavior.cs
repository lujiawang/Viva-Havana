using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Passer;

public class ClickingBehavior : MonoBehaviour
{
    public bool clicked = false;
    public void Clicked()
    {
        clicked = !clicked;
    }
}
