using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotController : MonoBehaviour {

	public SpriteRenderer sprSpot;
	public GameObject enemy;
	public GameObject player;
	public GameObject positionSpot;
	public SpriteRenderer backLayer;
	public bool validateOnlySpot;

	private float distancia;
	void Update(){
		if(validateOnlySpot){
			if(backLayer.enabled == false){
				distancia = 0;
			}else if(sprSpot.enabled){
				distancia = Vector2.Distance(player.transform.position,positionSpot.transform.position);
			}

			if (distancia < 2.5){
				enemy.tag = "CanFire";
			}else{
				enemy.tag = "CannotFire";
			}
			Debug.Log(distancia);
		}
	}

	public bool getSpotAction(){
		bool spotFlag;
		if (sprSpot.enabled == true && getDistance() < 1){
			spotFlag = true;
		}else{
			spotFlag = false;
		}

		return spotFlag;
	}

	private float getDistance(){
		float distancia = Vector2.Distance(player.transform.position,positionSpot.transform.position);
		return distancia;
	}

}
