﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseUp() {
        Manager.me.clickedOnPlant = true;
        Manager.me.changeText = true;
    }
}
