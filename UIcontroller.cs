using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIcontroller : MonoBehaviour {

	public Button b1;
	public Button b2;
	public float i;
	public Text paused;

	// Use this for initialization
	void Start () {
		i = 0;
		b1.onClick.AddListener (OnClickAction);
		b2.onClick.AddListener (onClickAction2);
		paused.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (i == 0) {
			Time.timeScale = 0.0f;
		} else
			Time.timeScale = 1.1f;
	}

	public void OnClickAction()
	{
		i = 1;
		paused.text = "";
	}
	public void onClickAction2()
	{
		i = 0;
		paused.text = "Paused";
	}
}
