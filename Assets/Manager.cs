using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
    public static Manager me;
    public GameObject flower1, flower2, flower3, flower4, scissors, water, shovel;

    public int stage;

    public TextMesh guideText;

    public bool scissorsInHand, waterInHand, shovelInHand, clickedOnPlant, changeText;
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
            flower1.gameObject.SetActive(true);
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
            if (changeText) {
                guideText.text = "Water the Plant";
                changeText = false;
            }
            flower2.gameObject.SetActive(true);
            flower1.gameObject.SetActive(false);
            if (clickedOnPlant && shovelInHand) {
                guideText.text = "There's nothing to Dig, Try the Water";
                changeText = false;
                clickedOnPlant = false;
            }
            if (clickedOnPlant && waterInHand) {
                stage += 1;
                clickedOnPlant = false;
                changeText = true;

            }
            if (clickedOnPlant && scissorsInHand) {
                guideText.text = "There's nothing to cut, Try the Water";
                changeText = false;
                clickedOnPlant = false;
                
            }
        }
        if(stage == 3) {
            if (changeText) {
                guideText.text = "Trim the Plant";
                changeText = false;
            }
            flower2.gameObject.SetActive(false);
            flower3.gameObject.SetActive(true);
            if (clickedOnPlant && shovelInHand) {
                guideText.text = "There's nothing to Dig, Try the Scissors";
                changeText = false;
                clickedOnPlant = false;
            }
            if (clickedOnPlant && waterInHand) {
                guideText.text = "There's nothing to Water, Try the Scissors";
                changeText = false;
                clickedOnPlant = false;
                

            }
            if (clickedOnPlant && scissorsInHand) {
                stage += 1;
                clickedOnPlant = false;
                changeText = true;
                
            }
        }
        if(stage == 4) {
            if (changeText) {
                guideText.text = "Your Flower is in Full Bloom!";
            }
            flower4.gameObject.SetActive(true);
            flower3.gameObject.SetActive(false);
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
