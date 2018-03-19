using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {
    public GameObject flower;
    public float rotateSpeed;
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(flower.transform);
       
        if (Input.GetKey(KeyCode.A)&&transform.position.x>-7) {
            transform.Translate(Vector3.left*Time.deltaTime*rotateSpeed);
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < 7) {
            transform.Translate(Vector3.right*Time.deltaTime*rotateSpeed);
        }
    }
}
