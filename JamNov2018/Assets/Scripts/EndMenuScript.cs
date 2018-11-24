using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuScript : MonoBehaviour {

	public GameObject canvasMainUI;

	public void NextLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void MainMenu(){
		SceneManager.LoadScene(0);
	}

	public void QuitGame(){
		print ("Bye bye!");
		Application.Quit ();
	}
}
