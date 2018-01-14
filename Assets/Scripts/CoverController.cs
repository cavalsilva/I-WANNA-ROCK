using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverController : MonoBehaviour {

	public GameObject cover;

	private float timerToDestroy;
	// Update is called once per frame
	void Update () {
		if (cover != null){
			timerToDestroy += Time.deltaTime;
			if (timerToDestroy > 5.0f){
				Destroy(cover);
			}
		}
	}
}
