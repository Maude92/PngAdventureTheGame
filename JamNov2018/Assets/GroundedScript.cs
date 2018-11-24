using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedScript : MonoBehaviour {

	public bool grounded;

	// Use this for initialization
	void Start () {
		grounded = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Ground" || other.gameObject.tag == "SwitchHeavy") {
			print ("Je suis grounded");
			grounded = true;
		}
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.tag == "Ground"|| other.gameObject.tag == "SwitchHeavy") {
			print ("Je suis pas grounded");
			grounded = false;
		}
	}
}
