using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour {

	public int changeplayer;

	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject player4;

	void Start (){
		changeplayer = 1;
	}

	void Update () {
//		if (Input.GetMouseButtonDown(0)) {
//			Debug.Log("Mouse Clicked");
//		}

		if (Input.GetMouseButtonDown(0)) {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

			RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
			if (hit.collider != null) {
				Debug.Log(hit.collider.gameObject.name);
				if (hit.collider.gameObject.tag == "Player") {
					print ("Yassss");
					changeplayer++;
				}
				//hit.collider.attachedRigidbody.AddForce(Vector2.up);
			}
		}


		if (changeplayer == 1) {
			player1.SetActive (true);
			player2.SetActive (false);
			player3.SetActive (false);
			player4.SetActive (false);
		} else if (changeplayer == 2) {
			player1.SetActive (false);
			player2.SetActive (true);
			player3.SetActive (false);
			player4.SetActive (false);
		} else if (changeplayer == 3) {
			player1.SetActive (false);
			player2.SetActive (false);
			player3.SetActive (true);
			player4.SetActive (false);
		} else if (changeplayer == 4) {
			player1.SetActive (false);
			player2.SetActive (false);
			player3.SetActive (false);
			player4.SetActive (true);
		} else if (changeplayer == 5) {
			changeplayer = 1;
		}
	}
}
