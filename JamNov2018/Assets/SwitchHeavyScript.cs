using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchHeavyScript : MonoBehaviour {

	public bool removeObstacle;

	public GameObject obstacle;
	Animator animobstacle;

	// Use this for initialization
	void Start () {
		animobstacle = obstacle.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (removeObstacle == true) {
			animobstacle.SetBool ("Activate", true);
		}
	}

	void OnTriggerStay2D (Collider2D other){
		//print ("Je touche à la switch : " + other.gameObject.name);
		if (other.gameObject.name == "SwitchForHeavy") {
			print ("T'es lourd.");
			Animator animSwitch;
			animSwitch = other.GetComponent<Animator> ();
			animSwitch.SetBool ("Activate", true);
			removeObstacle = true;
		}
	}
}
