using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpikes : MonoBehaviour {

    public GameObject LesMovingsSpikes;
    Animator animMovingSpikes;

	// Use this for initialization
	void Start () {
        animMovingSpikes = LesMovingsSpikes.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Bouncy" || other.gameObject.name == "Heavy" || other.gameObject.name == "Spiky")
        {
            //print("Je suis prêt a tuer");
            animMovingSpikes.SetBool("Kill", true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Bouncy" || other.gameObject.name == "Heavy" || other.gameObject.name == "Spiky")
        {
            animMovingSpikes.SetBool("Kill", false);
        }
    }
}
