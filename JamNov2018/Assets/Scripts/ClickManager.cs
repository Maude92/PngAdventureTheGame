using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour {

	public int changeplayer;
	public float jumpforce = 2;

	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject player4;

	Rigidbody2D rb1;
	Rigidbody2D rb2;
	Rigidbody2D rb3;
	Rigidbody2D rb4;

	GroundedScript groundedthescript1;
	GroundedScript groundedthescript2;
	GroundedScript groundedthescript3;
	GroundedScript groundedthescript4;
	public GameObject grounded1;
	public GameObject grounded2;
	public GameObject grounded3;
	public GameObject grounded4;

	void Start (){
		changeplayer = 1;

		rb1 = player1.GetComponent<Rigidbody2D> ();
		rb2 = player2.GetComponent<Rigidbody2D> ();
		rb3 = player3.GetComponent<Rigidbody2D> ();
		rb4 = player4.GetComponent<Rigidbody2D> ();

		groundedthescript1 = grounded1.GetComponent<GroundedScript> ();
		groundedthescript2 = grounded2.GetComponent<GroundedScript> ();
		groundedthescript3 = grounded3.GetComponent<GroundedScript> ();
		groundedthescript4 = grounded4.GetComponent<GroundedScript> ();
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
					if (changeplayer == 1 && groundedthescript1.grounded == true) { 
						changeplayer++;
					} else if (changeplayer == 2 && groundedthescript2.grounded == true) {
						changeplayer++;
					} else if (changeplayer == 3 && groundedthescript3.grounded == true) {
						changeplayer++;
					} else if (changeplayer == 4 && groundedthescript4.grounded == true) {
						changeplayer++;
					}
				} 

				if (hit.collider.gameObject.tag == "Background") {
					print ("Je clique pas sur le player");
					if (changeplayer == 1 && groundedthescript1.grounded == true) {
						rb1.AddForce(new Vector2 (0, jumpforce));
						rb2.AddForce(new Vector2 (0, jumpforce));
						rb3.AddForce(new Vector2 (0, jumpforce));
						rb4.AddForce(new Vector2 (0, jumpforce));
					} else if (changeplayer == 2 && groundedthescript2.grounded == true) {
						rb1.AddForce(new Vector2 (0, jumpforce));
						rb2.AddForce(new Vector2 (0, jumpforce));
						rb3.AddForce(new Vector2 (0, jumpforce));
						rb4.AddForce(new Vector2 (0, jumpforce));
					} else if (changeplayer == 3 && groundedthescript3.grounded == true) {
						rb1.AddForce(new Vector2 (0, jumpforce));
						rb2.AddForce(new Vector2 (0, jumpforce));
						rb3.AddForce(new Vector2 (0, jumpforce));
						rb4.AddForce(new Vector2 (0, jumpforce));
					} else if (changeplayer == 4 && groundedthescript4.grounded == true) {
						rb1.AddForce(new Vector2 (0, jumpforce));
						rb2.AddForce(new Vector2 (0, jumpforce));
						rb3.AddForce(new Vector2 (0, jumpforce));
						rb4.AddForce(new Vector2 (0, jumpforce));
					}
				}
				//hit.collider.attachedRigidbody.AddForce(Vector2.up);
			}
		}


		if (changeplayer == 1) {
			player1.SetActive (true);
			player2.SetActive (false);
			player3.SetActive (false);
			player4.SetActive (false);
			jumpforce = 500;
		} else if (changeplayer == 2) {
			player1.SetActive (false);
			player2.SetActive (true);
			player3.SetActive (false);
			player4.SetActive (false);
			jumpforce = 300;
		} else if (changeplayer == 3) {
			player1.SetActive (false);
			player2.SetActive (false);
			player3.SetActive (true);
			player4.SetActive (false);
			jumpforce = 100;
		} else if (changeplayer == 4) {
			player1.SetActive (false);
			player2.SetActive (false);
			player3.SetActive (false);
			player4.SetActive (true);
			jumpforce = 100;
		} else if (changeplayer == 5) {
			changeplayer = 1;
		}
	}
}
