using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour {

	public SpriteRenderer sprLight;
	public GameObject enemy;

	public SpotController spotsLights;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(sprLight.enabled == true){
			enemy.tag = "CanFire";
		}else{
			if (spotsLights.getSpotAction()){
				enemy.tag = "CanFire";
			}else{
				enemy.tag = "CannotFire";
			}
		}
	}
}
