using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PolymorphTimer : MonoBehaviour {

	public Text timerText;
	public int temps = 0;
	public bool timerOn;

	public float seconds, minutes;

	// Use this for initialization
	void Start () {
		//StartCoroutine ("StartTimer");
		timerOn = true;
	}
	
	// Update is called once per frame
	void Update () {
		//timerText.text = ("" + temps);
		timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

		if (timerOn == true) {
			minutes = (int)(Time.timeSinceLevelLoad / 60f);
			seconds = (int)(Time.time % 60f);
		} else if (timerOn == false) {
			print ("Le timer devrait arrêter, if he's nice");
		}
	}

//	IEnumerator StartTimer() {
////		while (true) {
////			yield return new WaitForSeconds (1);
////			temps++;
////		}
////		minutes = (int)(Time.timeSinceLevelLoad/60f);
////		seconds = (int)(Time.time % 60f);
////		yield return new WaitForSeconds (0.1f);
//
//	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			timerOn = false;
//			StopCoroutine ("LoseTime");
		}
	}
}
