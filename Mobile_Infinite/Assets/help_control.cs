﻿using UnityEngine;
using System.Collections;

public class help_control : MonoBehaviour {
	
	void Update()
	{
		if (Application.platform == RuntimePlatform.WindowsEditor) {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.Quit();
				//UnityEditor.EditorApplication.isPlaying = false;
				return;
			}
			//Time.timeScale = 0;
		}
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.Quit ();
				//UnityEditor.EditorApplication.isPlaying = false;
				return;
			}
			//Time.timeScale = 0;
		}
	}
	void OnTouchDown()
	{
		//Time.timeScale = 1;
		//Destroy (gameObject);
		GetComponent<AudioSource>().Play ();
		Application.LoadLevel("help_menu");
	}
	/*void OnTouchUp()
	{

	}
	void OnTouchStay()
	{
		Destroy (gameObject);
	}
	void OnTouchExit()
	{

	}*/
}