using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public int tempoRonda;  // Amount to move left and right from the start point
	public float velocidade = 2.0f; 
	private Vector3 posicaoInicial;
	public int orientacao; //Sistema simples para determinar para qual lado o inimigo começa a ronda.
	public int tempoPausa;

	private float temp;
	private float temp2;
	private float parada;

	private bool shouldMove = true;

	private Vector3 v;

	// Use this for initialization
	void Start () {
		posicaoInicial = transform.position;
		temp = tempoRonda / 2 ;
		temp2 = tempoPausa;	
	}


	// Update is called once per frame
	void Update () {

		v = posicaoInicial;
		
		if ( shouldMove ){

			if (orientacao == 0) { // Se locomove para a direita, depois para a esquerda.

				v.x += tempoRonda * Mathf.Sin (Time.time * velocidade);

			}
			else if ( orientacao == 1 ){// Se locomove para a esquerda, depois para a direita.
				v.x -= tempoRonda * Mathf.Sin (Time.time * velocidade);
			}
			
			transform.position = v;


			temp -= Time.deltaTime;
			
			if ( temp < 0 ){
				shouldMove = false;
				 //parada = v.x;
			}

		}
		else{
			temp2 -= Time.deltaTime;
			if ( temp2 < 0 ){
				shouldMove = true;			
			}		

		}
	}
}
