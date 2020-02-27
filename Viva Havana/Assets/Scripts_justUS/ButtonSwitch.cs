using Passer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonSwitch: MonoBehaviour
{

	public GameObject definedButton;
	public UnityEvent OnClick = new UnityEvent();
    public ClickingBehavior ck;

	// Use this for initialization
	void Start()
	{
		definedButton = this.gameObject;
	}

	// Update is called once per frame
	void Update()
	{
        if (ck)
        {
            OnClick.Invoke();
        }
        
/*		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

       
		RaycastHit Hit;
        
		if (Input.GetMouseButtonDown(0))
		{
			if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
			{
				Debug.Log("Button Clicked");
				OnClick.Invoke();
			}
		}*/
	}
}