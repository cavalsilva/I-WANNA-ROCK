using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouRockController : MonoBehaviour {

	private float timerMin = 0.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timerMin += Time.deltaTime;

		if (timerMin > 3.0f)
			SceneManager.LoadScene("Winner");		
	}
}
