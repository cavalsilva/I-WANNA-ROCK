using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTransitionDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (GameObject.Find("MusicCon"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
