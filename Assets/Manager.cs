using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
    public static Manager me;
    public GameObject flower, scissors, water, shovel;

    public int stage;

    public TextMesh guideText;

    public bool scissorsInHand, waterInHand, shovelInHand, clickedOnPlant;
	// Use this for initialization
	void Awake () {
		if(me == null) {
            me = this;
        }
        else {
            Destroy(this);
        }
	}



	void Start() {
        stage = 1;
        guideText.text = "Plant a hole for the seed";

    }




	void Update () {
        if(stage == 1) {
            if(clickedOnPlant && shovelInHand) {
                stage += 1;
                clickedOnPlant = false;
            }
            if(clickedOnPlant && waterInHand) {
                guideText.text = "There's nothing to water, Try the Shovel";
                clickedOnPlant = false;
            }
            if(clickedOnPlant && scissorsInHand) {
                guideText.text = "There's nothing to cut, Try the Shovel";
                clickedOnPlant = false;
            }
        }
		if(stage == 2) {
            
            if (clickedOnPlant && shovelInHand) {
                stage += 1;
                clickedOnPlant = false;
            }
            if (clickedOnPlant && waterInHand) {
                guideText.text = "There's nothing to water, Try the Shovel";
                clickedOnPlant = false;
            }
            if (clickedOnPlant && scissorsInHand) {
                guideText.text = "There's nothing to cut, Try the Shovel";
                clickedOnPlant = false;
            }
        }
        if(stage == 3) {

        }
        if(stage == 4) {

        }
	}

    void Holding(string beingHeld) {
        Debug.Log("I'm holding a " + beingHeld);
        if(beingHeld == "Scissors") {
            scissorsInHand = true;
            waterInHand = false;
            shovelInHand = false;
        }else
        if(beingHeld == "Water") {
            waterInHand = true;
            shovelInHand = false;
            scissorsInHand = false;
        }else
        if(beingHeld == "Shovel") {
            shovelInHand = true;
            waterInHand = false;
            scissorsInHand = false;
        }
    }
}
