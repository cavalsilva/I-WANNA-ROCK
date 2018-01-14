using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {


	public void LoadCinematic(){
		OpenScene ("Cinematic");
	}

	public void LoadCredits(){
		OpenScene ("Credits");
	}

	public void LoadGameOver(){
		OpenScene ("GameOver");
	}

	public void LoadStartScreen(){
		OpenScene ("StartScreen");
	}

	public void LoadWinner(){
		OpenScene ("Winner");
	}

	public void LoadTutorial(){
		OpenScene("Tutorial");
	}

	public void LoadGameLevel(string name){
		OpenScene (name);
	}

	private void OpenScene(string nameScene){
		SceneManager.LoadScene (nameScene);
	}
		
}
