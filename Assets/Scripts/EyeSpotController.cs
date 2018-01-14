using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;


public class EyeSpotController : MonoBehaviour {

	public float timeAnimationNormal;
	public float timeAnimationFrantic;
	public bool playerIsHidden;
	public bool spotOff;

	private float fraction;
	private float countingTime;
	private SkeletonAnimation eye;
	private SceneController scene;
	// Use this for initialization
	void Start () {
		//Seta componente no atributo
		eye = gameObject.GetComponent<SkeletonAnimation>();

		scene = new SceneController ();

		//Nesta caso 6.0 é a quantidade de animação normal
		fraction = (timeAnimationNormal / 6.0f);
	}
	
	// Update is called once per frame
	void Update () {

		if (playerIsHidden || spotOff){
			if(countingTime > 0){
				countingTime -= Time.deltaTime;
			}else{
				countingTime = 0;
			}
		}else{
			countingTime += Time.deltaTime;
		}

		if (countingTime <= fraction){
			eye.AnimationName = "eye1";
		}else if (countingTime <= fraction * 2){
			eye.AnimationName = "eye2";
		}else if (countingTime <= fraction * 3){
			eye.AnimationName = "eye3";
		}else if (countingTime <= fraction * 4){
			eye.AnimationName = "eye4";
		}else if (countingTime <= fraction * 5){
			eye.AnimationName = "eye5";
		}else if (countingTime <= fraction * 6){
			eye.AnimationName = "eye6";		
		}else if (countingTime <= ((fraction * 6) +4) ){
			eye.AnimationName = "eye7";
		}else{
			scene.LoadGameOver();
		}
	}

}
