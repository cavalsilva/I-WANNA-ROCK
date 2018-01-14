using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerCinematic : MonoBehaviour {

	// public float tempoParaFecharCinematic;

	public float tempoParaComecarJogo;
	private float fadeOutMusic = 5;
	private AudioSource audio;

	void FixedUpdate(){

		if (tempoParaComecarJogo > 0){
			tempoParaComecarJogo -= Time.fixedDeltaTime;
		}
		else{
			if (fadeOutMusic > 0){
				Debug.Log(fadeOutMusic);
				fadeOutMusic -= Time.fixedDeltaTime;
				audio.volume -= 0.006f;
			}
			else{
				SceneController sn = gameObject.GetComponent<SceneController>();
				sn.LoadTutorial();
			}
		}

	}

	// Use this for initialization
	void Start () {
		 audio = GameObject.FindGameObjectWithTag("Hidden").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {	

		if ( Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown( KeyCode.Escape ) ) { 
			SceneController sn = gameObject.GetComponent<SceneController>();
			sn.LoadTutorial();
		}

	}
}
