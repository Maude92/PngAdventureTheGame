using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuScript : MonoBehaviour {

	public GameObject canvasMainUI;

	private AudioManager audioManager;

	void Start () {
		audioManager = AudioManager.instance;
		if (audioManager == null) {
			Debug.LogError ("Attention, le AudioManager n'a pas été trouvé dans la scène.");}
	}

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

	public void RetryLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	public void ClickSound(){
		audioManager.PlaySound ("Click");
	}
}
