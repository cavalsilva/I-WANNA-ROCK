using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotOnlyController : MonoBehaviour {

	public SpriteRenderer sprSpot1;
	public SpriteRenderer sprSpot2;
	public SpriteRenderer sprSpot3;
	public GameObject enemy;
	public GameObject player;
	public GameObject positionSpot1;
	public GameObject positionSpot2;
	public GameObject positionSpot3;
	public SpriteRenderer backLayer;
	public EyeSpotController eyeController;

	private float distancia = 10;
	void Update(){
		if(backLayer.enabled == false){
			distancia = 0;
		}else if(sprSpot1.enabled){
			distancia = Vector2.Distance(player.transform.position,positionSpot1.transform.position);
		}else if(sprSpot2.enabled){
			distancia = Vector2.Distance(player.transform.position,positionSpot2.transform.position);
		}else if(sprSpot3.enabled){
			distancia = Vector2.Distance(player.transform.position,positionSpot3.transform.position);
		}						

		if (distancia < 2.5){
			enemy.tag = "CanFire";
			eyeController.spotOff = false;
		}else{
			enemy.tag = "CannotFire";
			eyeController.spotOff = true;
		}
		Debug.Log(distancia);
	}
}
