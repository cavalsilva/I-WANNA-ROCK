using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirSomJogoController : MonoBehaviour {

	private GameObject somJogo;

	// Use this for initialization
	void Start () {

		Destroy (GameObject.FindWithTag("BackgroundMusic"));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
