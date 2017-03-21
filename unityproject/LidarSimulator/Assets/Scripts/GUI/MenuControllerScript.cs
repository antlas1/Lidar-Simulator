﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControllerScript : MonoBehaviour {

	public GameObject editorMenu;
	LidarSensor sensor;

	// Use this for initialization
	void Start () {
		sensor = GameObject.FindGameObjectWithTag ("Lidar").GetComponent<LidarSensor> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayButton(){
		//sensor.playSimulation = !sensor.playSimulation;
	}

	void OnGUI(){
		if(gameObject.GetComponent<Toggle>().isOn){
			editorMenu.SetActive (false);
		}
		else{
			editorMenu.SetActive (true);
		}
	}
}
