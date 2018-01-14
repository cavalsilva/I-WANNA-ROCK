using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {
	public float timeTotal;
	public float timeTotalHorizontalLamp;
	public float timeLightVerticalLamp;
	public float timeLightHorizontalLamp;
	public SpriteRenderer lightVertical;
	public SpriteRenderer lightHorizontal;
	public SpriteRenderer backLight;
	public EyeController eye;
	public GameObject player;
	private float countTimer;
	private float countParcial;

	void Update(){
		countTimer += Time.deltaTime;
		
		if(countTimer < timeLightVerticalLamp){
			if(player.CompareTag("Player")){
				eye.playerIsHidden = true;
			}
		}
		if(countTimer >= timeLightVerticalLamp && countTimer < (timeLightVerticalLamp + timeLightHorizontalLamp) ){
			lightVertical.enabled = true;
			countParcial = timeLightVerticalLamp + timeLightHorizontalLamp;		
			if(player.CompareTag("Player")){
				eye.playerIsHidden = false;
			}				
		}
		if (countTimer >= (timeLightVerticalLamp + timeLightHorizontalLamp) && countTimer < (timeTotalHorizontalLamp + countParcial)){
			lightVertical.enabled = false;
			lightHorizontal.enabled = true;
			backLight.enabled = false;
			if(player.CompareTag("Player")){
				eye.playerIsHidden = false;
			}							
		}
		if(countTimer >= (timeTotalHorizontalLamp + countParcial)){
			lightVertical.enabled = false;
			lightHorizontal.enabled = false;
			backLight.enabled = true;
			countTimer = 0;
			if(player.CompareTag("Player")){
				eye.playerIsHidden = true;
			}							
		}
	}
}
