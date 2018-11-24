using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public GameObject canvasMainUI;
	public GameObject canvasInfosUI;
	public GameObject canvasCreditsUI;

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

	public void ShowCredits(){
		canvasMainUI.SetActive (false);
		canvasCreditsUI.SetActive (true);
	}

	public void ReturnFromCredits(){
		canvasCreditsUI.SetActive (false);
		canvasMainUI.SetActive (true);
	}

	public void ShowMoreInfos(){
		canvasMainUI.SetActive (false);
		canvasInfosUI.SetActive (true);
	}

	public void ReturnFromInfos(){
		canvasInfosUI.SetActive (false);
		canvasMainUI.SetActive (true);
	}
}
