using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour {

	private SpriteRenderer render;

	private float flag;



	public Sprite imagem1;
	public Sprite imagem2;
	public Sprite imagem3;

	public Sprite imagem4;

	public Sprite imagem5;

	public Sprite imagem6;

	public Sprite imagem7;

	

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<SpriteRenderer> ().sprite = imagem1;
		flag++;
	}
	
	// Update is called once per frame
	void Update () {

		Time.timeScale = 0f;

		if ( Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return) ) {

			if ( flag == 1 )
				gameObject.GetComponent<SpriteRenderer> ().sprite = imagem2;

			if ( flag == 2 ){
				transform.position = new Vector2( -2.08f, -3.64f);
				gameObject.GetComponent<SpriteRenderer> ().sprite = imagem3;
			}
				
			if ( flag == 3 ){
				 transform.position = new Vector2( 1.82f, 2.52f);
				 gameObject.GetComponent<SpriteRenderer> ().sprite = imagem4;
			}
			if ( flag == 4 ){
				transform.position = new Vector2( 1.371f, -0.134f); 
				gameObject.GetComponent<SpriteRenderer> ().sprite = imagem5;
				
			}
			if ( flag == 5 ){
				transform.position = new Vector2( 2.419f, -2.339f);
				gameObject.GetComponent<SpriteRenderer> ().sprite = imagem6;
				
			}
			if ( flag == 6 ){
				transform.position = new Vector2( -3.6f, 0.7f);
				gameObject.GetComponent<SpriteRenderer> ().sprite = imagem7;	
			}
			if ( flag == 7){
				// Começa o game !
			}

			flag++;	
		 }		
	}
}
