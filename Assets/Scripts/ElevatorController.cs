using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorController : MonoBehaviour {

	private bool estaNoElevator = false;
	private string nomeScene;

	public MeshRenderer hintElevator;


	void Start(){
		nomeScene = SceneManager.GetActiveScene().name;		
	}

	void Update(){
		if (estaNoElevator){
			if (Input.GetKeyDown (KeyCode.Space)) {
				if (nomeScene == "Level1"){
					SceneManager.LoadScene("Level2");
				}
				if (nomeScene == "Level2"){
					SceneManager.LoadScene("Level3");
				}
				if (nomeScene == "Level3"){
					SceneManager.LoadScene("YouRock");
				}				
			}
		}		
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			hintElevator.enabled = true;
			estaNoElevator = true;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if(other.CompareTag("Player")){
			hintElevator.enabled = false;
			estaNoElevator = false;
		}
	}
}
