using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControllerOnlyVertical : MonoBehaviour {

	public float timeTotal;
	public float timeTotalLamps;
	public float timeLightVerticalLamp1;
	public float timeLightVerticalLamp2;
	public float timeLightVerticalLamp3;
	public SpriteRenderer lightVertical1;
	public SpriteRenderer lightVertical2;
	public SpriteRenderer lightVertical3;
	public SpriteRenderer backLight;
	public EyeController eye;
	public GameObject player;
	private float countTimer;
	private float countParcial;

	void Update(){
		countTimer += Time.deltaTime;
		
		if(countTimer < timeLightVerticalLamp1){
			if(player.CompareTag("Player")){
				eye.playerIsHidden = true;
			}
		}
		if(countTimer >= timeLightVerticalLamp1 && countTimer < (timeLightVerticalLamp1 + timeLightVerticalLamp2) ){
			lightVertical1.enabled = true;
			lightVertical2.enabled = false;
			lightVertical3.enabled = false;
			backLight.enabled = true;
			countParcial = timeLightVerticalLamp1 + timeLightVerticalLamp2 + timeLightVerticalLamp3;		
			if(player.CompareTag("Player")){
				eye.playerIsHidden = false;
			}				
		}
		if (countTimer >= (timeLightVerticalLamp1 + timeLightVerticalLamp2) && countTimer < (timeTotalLamps + countParcial)){
			lightVertical1.enabled = false;
			lightVertical2.enabled = true;
			lightVertical3.enabled = false;
			backLight.enabled = true;
			if(player.CompareTag("Player")){
				eye.playerIsHidden = false;
			}							
		}
		if (countTimer >= (timeLightVerticalLamp1 + timeLightVerticalLamp2 + timeLightVerticalLamp3) && countTimer < (timeTotalLamps + countParcial)){
			lightVertical1.enabled = false;
			lightVertical2.enabled = false;
			lightVertical3.enabled = true;
			backLight.enabled = true;
			if(player.CompareTag("Player")){
				eye.playerIsHidden = false;
			}							
		}		
		if(countTimer >= (timeTotalLamps + countParcial)){
			lightVertical1.enabled = false;
			lightVertical2.enabled = false;
			lightVertical3.enabled = false;
			backLight.enabled = true;
			countTimer = 0;
			if(player.CompareTag("Player")){
				eye.playerIsHidden = true;
			}							
		}
	}

}
