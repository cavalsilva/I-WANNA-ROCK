using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	public AudioSource musicIntro;
	public AudioSource musicLoop;
	// Use this for initialization
	
    void Start()
    {
		musicLoop.Play();
    }

	
}
