﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseUp() {
        SendMessageUpwards("Holding", this.gameObject.name, SendMessageOptions.DontRequireReceiver);
    }
}
