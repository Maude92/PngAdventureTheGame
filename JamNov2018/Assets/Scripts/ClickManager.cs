using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour {

	public int changeplayer;
	public float jumpforce = 2;
	public int nbVie;

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

	public GameObject heartPart1;
	public GameObject heartPart2;
	public GameObject heartPart3;
	public GameObject heartPart4;
	public GameObject heartPart5;
	public GameObject heartPart6;
	public GameObject heartPart7;
	public GameObject heartPart8;
	public GameObject heartPart9;
	public GameObject heartPart10;
	public GameObject heartPart11;
	public GameObject heartPart12;
	public GameObject heartPart13;
	public GameObject heartPart14;
	public GameObject heartPart15;
	public GameObject heartPart16;


	void Start (){
		changeplayer = 1;
		nbVie = 16;

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

				// QUAND ON CLIQUE SUR LE PLAYER
				if (hit.collider.gameObject.tag == "Player") {
					print ("Yassss");
					if (changeplayer == 1 && groundedthescript1.grounded == true) { 
						changeplayer++;
						nbVie--;
					} else if (changeplayer == 2 && groundedthescript2.grounded == true) {
						changeplayer++;
						nbVie--;
					} else if (changeplayer == 3 && groundedthescript3.grounded == true) {
						changeplayer++;
						nbVie--;
					} else if (changeplayer == 4 && groundedthescript4.grounded == true) {
						changeplayer++;
						nbVie--;
					}
				} 

				// QUAND ON CLIQUE AILLEURS 
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
	
	// GESTION DES COEURS POUR LA VIE DU JOUEUR
		if (nbVie >= 16){
			nbVie = 16;
		}

		if (nbVie == 16) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (true);
			heartPart8.SetActive (true);
			heartPart9.SetActive (true);
			heartPart10.SetActive (true);
			heartPart11.SetActive (true);
			heartPart12.SetActive (true);
			heartPart13.SetActive (true);
			heartPart14.SetActive (true);
			heartPart15.SetActive (true);
			heartPart16.SetActive (true);
		} else if (nbVie == 15) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (true);
			heartPart8.SetActive (true);
			heartPart9.SetActive (true);
			heartPart10.SetActive (true);
			heartPart11.SetActive (true);
			heartPart12.SetActive (true);
			heartPart13.SetActive (true);
			heartPart14.SetActive (true);
			heartPart15.SetActive (true);
			heartPart16.SetActive (false);
		} else if (nbVie == 14) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (true);
			heartPart8.SetActive (true);
			heartPart9.SetActive (true);
			heartPart10.SetActive (true);
			heartPart11.SetActive (true);
			heartPart12.SetActive (true);
			heartPart13.SetActive (true);
			heartPart14.SetActive (true);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 13) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (true);
			heartPart8.SetActive (true);
			heartPart9.SetActive (true);
			heartPart10.SetActive (true);
			heartPart11.SetActive (true);
			heartPart12.SetActive (true);
			heartPart13.SetActive (true);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 12) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (true);
			heartPart8.SetActive (true);
			heartPart9.SetActive (true);
			heartPart10.SetActive (true);
			heartPart11.SetActive (true);
			heartPart12.SetActive (true);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 11) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (true);
			heartPart8.SetActive (true);
			heartPart9.SetActive (true);
			heartPart10.SetActive (true);
			heartPart11.SetActive (true);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 10) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (true);
			heartPart8.SetActive (true);
			heartPart9.SetActive (true);
			heartPart10.SetActive (true);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 9) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (true);
			heartPart8.SetActive (true);
			heartPart9.SetActive (true);
			heartPart10.SetActive (false);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 8) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (true);
			heartPart8.SetActive (true);
			heartPart9.SetActive (false);
			heartPart10.SetActive (false);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 7) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (true);
			heartPart8.SetActive (false);
			heartPart9.SetActive (false);
			heartPart10.SetActive (false);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 6) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (true);
			heartPart7.SetActive (false);
			heartPart8.SetActive (false);
			heartPart9.SetActive (false);
			heartPart10.SetActive (false);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 5) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (true);
			heartPart6.SetActive (false);
			heartPart7.SetActive (false);
			heartPart8.SetActive (false);
			heartPart9.SetActive (false);
			heartPart10.SetActive (false);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 4) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (true);
			heartPart5.SetActive (false);
			heartPart6.SetActive (false);
			heartPart7.SetActive (false);
			heartPart8.SetActive (false);
			heartPart9.SetActive (false);
			heartPart10.SetActive (false);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 3) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (true);
			heartPart4.SetActive (false);
			heartPart5.SetActive (false);
			heartPart6.SetActive (false);
			heartPart7.SetActive (false);
			heartPart8.SetActive (false);
			heartPart9.SetActive (false);
			heartPart10.SetActive (false);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 2) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (true);
			heartPart3.SetActive (false);
			heartPart4.SetActive (false);
			heartPart5.SetActive (false);
			heartPart6.SetActive (false);
			heartPart7.SetActive (false);
			heartPart8.SetActive (false);
			heartPart9.SetActive (false);
			heartPart10.SetActive (false);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie == 1) {
			heartPart1.SetActive (true);
			heartPart2.SetActive (false);
			heartPart3.SetActive (false);
			heartPart4.SetActive (false);
			heartPart5.SetActive (false);
			heartPart6.SetActive (false);
			heartPart7.SetActive (false);
			heartPart8.SetActive (false);
			heartPart9.SetActive (false);
			heartPart10.SetActive (false);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		} else if (nbVie < 1) {
			nbVie = 0;
			print ("You died! :( ");
			heartPart1.SetActive (false);
			heartPart2.SetActive (false);
			heartPart3.SetActive (false);
			heartPart4.SetActive (false);
			heartPart5.SetActive (false);
			heartPart6.SetActive (false);
			heartPart7.SetActive (false);
			heartPart8.SetActive (false);
			heartPart9.SetActive (false);
			heartPart10.SetActive (false);
			heartPart11.SetActive (false);
			heartPart12.SetActive (false);
			heartPart13.SetActive (false);
			heartPart14.SetActive (false);
			heartPart15.SetActive (false);
			heartPart16.SetActive (false);
		}
	}

}
