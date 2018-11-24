using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float xMargin = 1f;
	public float yMargin = 1f;
	public float xySmooth = 3;
	public Vector2 maxXY;
	public Vector2 minXY;

	Transform playerTransform;


	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;		// FindWithTag fonctionne aussi
	}


	// Update is called once per frame
	void Update () {
		
	}


	void LateUpdate(){
		trackPlayer ();					// On appelle la méthode
	}


	bool CheckXMargin() {
		return Mathf.Abs (transform.position.x - playerTransform.position.x) > xMargin;		// Abs = valeur absolue		est-ce que la valeur absolue de la position de la caméra moins la 
																							// position de mon personnage, est-ce que c'est plus grand que la marge de 1 que je m'étais donné
																							// Si ça dépasse, devient true
																							// Est-ce que c'est vrai ou faux que c'est plus grand que xMargin
																						// Mathf = fonction mathématique qu'on applique sur des floats (genre)
	}


	bool CheckYMargin() {																	// Même chose mais pour Y
		return Mathf.Abs (transform.position.y - playerTransform.position.y) > yMargin;
	}



	void trackPlayer() {																	// On doit exécuter cette fonction là à toutes les frames, mais écrit juste comme ça personne appelle la méthode
		float targetX = transform.position.x;
		float targetY = transform.position.y;

		if (CheckXMargin ())			// si ressort true
			targetX = Mathf.Lerp (transform.position.x, playerTransform.position.x, xySmooth * Time.deltaTime);		// La position qu'on aimerait que ça ait
			

		targetX = Mathf.Clamp (targetX, minXY.x, maxXY.x);									// On veut pas que ça dépasse les limites du level donc on fait un clamp. 
																							// Si c'est plus petit que minXY, garde la valeur minimum, si c'est plus grand que le max 
																							// (ex: 5 et le max c'est 3, sort 3), si c'est la bonne valeur (ex: 2.5 et le max c'est 3 et 
																							// min 0, garde 2.5)

		if (CheckYMargin ())			// si ressort true
			targetY = Mathf.Lerp (transform.position.y, playerTransform.position.y, xySmooth * Time.deltaTime);

		targetY = Mathf.Clamp (targetY, minXY.y, maxXY.y);


		transform.position = new Vector3 (targetX, targetY, transform.position.z);			// La caméra est un vector 3 même dans un jeu 2D pcq elle peut bouger sur les Z aussi
																							// C'est avec ça qu'on change officiellement sa position, avant on faisait juste déterminer sa 
																							// position, mais avec ça on la bouge
	
	}


}
