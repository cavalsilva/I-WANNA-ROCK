using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStealth : MonoBehaviour {

	public SpriteRenderer botaoE;
	public SpriteRenderer botaoQ;
	public GameObject positionCaixa;
	private bool colidiuCaixa = false;
	private bool estaNaCaixa = false;
	private bool estaNoElevator = false;

	//Variaveis que controlam o tempo do click do space
	private float keyTimer = 0f;
	private float keyLenght = 0.1f;
	private bool isKeyActive = false;
	private string nomeScene;

	void Start()
	{
		nomeScene = SceneManager.GetActiveScene().name;
	}

	void Update()
	{
		/*
		if (colidiuCaixa && !estaNaCaixa && !isKeyActive) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				EsconderNaCaixa ();
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


		if (estaNoElevator){
			if (Input.GetKeyDown (KeyCode.Space)) {
				if (nomeScene == "Level1"){
					SceneManager.LoadScene("Level2");
				}
				if (nomeScene == "Level2"){
					SceneManager.LoadScene("Level3");
				}
				if (nomeScene == "Level3"){
					SceneManager.LoadScene("YouRock");
				}				
			}
		}
		 */		
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		/*
		if (other.gameObject.name == "Caixa"){
			if(gameObject.CompareTag("Player")){
				ExibeInteracaoBotaoCaixa ();
			}
		}


		if (other.gameObject.name == "Elevator") {
			if(gameObject.CompareTag("Player")){
				estaNoElevator = true;
			}
		}
		*/					
	}

	void OnTriggerExit2D(Collider2D other)
	{
		/*
		if(gameObject.CompareTag("Player")){
			EscondeInteracaoBotaoCaixa ();
			estaNoElevator = false;
		}
		*/	


	}
/*
	void EsconderNaCaixa()
	{
		gameObject.GetComponent<MeshRenderer> ().enabled = false;
		estaNaCaixa = true;
		gameObject.GetComponent<PlayerController> ().blockInputArrow = true;
		gameObject.transform.position = positionCaixa.transform.position;
		botaoE.enabled = false;
		botaoQ.enabled = true;
		GetComponent<TimerController> ().ResetTimer ();

		//Set Tag Hidden
		gameObject.tag = "Hidden";
	}

	void SairDaCaixa()
	{
		gameObject.GetComponent<MeshRenderer> ().enabled = true;
		estaNaCaixa = false;
		gameObject.GetComponent<PlayerController> ().blockInputArrow = false;
		botaoE.enabled = true;
		botaoQ.enabled = false;
		GetComponent<TimerController> ().PlayTimer ();

		//Set Tag Player
		gameObject.tag = "Player";		
	}

	void ExibeInteracaoBotaoCaixa()
	{
		botaoE.enabled = true;
		colidiuCaixa = true;		
	}

	void EscondeInteracaoBotaoCaixa()
	{
		botaoE.enabled = false;
		colidiuCaixa = false;
	}
*/	
}
