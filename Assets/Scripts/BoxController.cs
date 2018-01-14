using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;
public class BoxController : MonoBehaviour {


	public GameObject player;
	public GameObject posBox;
	public EyeController eye;
	public SkeletonAnimation boxAnimation;
	private bool estaNaCaixa = false;
	private bool colidiuCaixa = false;
	private float keyTimer = 0f;
	private float keyLenght = 0.1f;
	private bool isKeyActive = false;	

	void Update(){
		if(colidiuCaixa && !estaNaCaixa){
			if (Input.GetKeyDown (KeyCode.Space)) {
				EsconderNaCaixa();
				keyTimer = Time.time;
				isKeyActive = true;				
			}
		}

		if (estaNaCaixa && isKeyActive) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				if (Time.time - keyTimer > keyLenght) {
					SairDaCaixa ();
					isKeyActive = false;
				}
			}
		}		
	}
	void OnTriggerEnter2D(Collider2D other){
		if(player.CompareTag("Player")){
			colidiuCaixa = true;
			//ExibeInteracaoBotaoCaixa();
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if(player.CompareTag("Player")){
			colidiuCaixa = false;
			//EscondeInteracaoBotaoCaixa();
		}
	}

/*	void ExibeInteracaoBotaoCaixa(){
		imgShow.enabled = true;
	}
*/
/*	void EscondeInteracaoBotaoCaixa(){
		imgShow.enabled = false;
	}
*/
	void EsconderNaCaixa()
	{
		player.GetComponent<MeshRenderer>().enabled = false;
		estaNaCaixa = true;
		player.GetComponent<PlayerController>().blockInputArrow = true;
		player.transform.position = posBox.transform.position;
		//imgShow.enabled = false;
		//imgHide.enabled = true;
		boxAnimation.AnimationName = "out";
		//eye.GetComponent<TimerController>().ResetTimer();

		//Set Tag Hidden
		player.tag = "Hidden";
		eye.playerIsHidden = true;
	}	

	void SairDaCaixa()
	{
		player.GetComponent<MeshRenderer> ().enabled = true;
		estaNaCaixa = false;
		player.GetComponent<PlayerController> ().blockInputArrow = false;
		//imgShow.enabled = true;
		//imgHide.enabled = false;
		//eye.GetComponent<TimerController>().PlayTimer();
		boxAnimation.AnimationName = "in";

		//Set Tag Player
		player.tag = "Player";
		eye.playerIsHidden = false;	
	}	
}
