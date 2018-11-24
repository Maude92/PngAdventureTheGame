using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchHeavyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		//print ("Je touche à la switch : " + other.gameObject.name);
		if (other.gameObject.name == "SwitchForHeavy") {
			print ("T'es lourd.");
		}
	}
}
