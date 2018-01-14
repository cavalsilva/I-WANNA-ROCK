using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialTipsController : MonoBehaviour {

	public SpriteRenderer ballon01;
	public SpriteRenderer ballon02;
	//public SpriteRenderer btnEnterBallon;
	public SpriteRenderer tuto01bg;
	public SpriteRenderer tuto01;
	//public SpriteRenderer btnEnter01;
	public SpriteRenderer tuto02bg;
	public SpriteRenderer tuto02;
	//public SpriteRenderer btnEnter02;
	public SpriteRenderer tuto03bg;
	public SpriteRenderer tuto03;
	//public SpriteRenderer btnEnter03;
	public SpriteRenderer tuto04bg;
	public SpriteRenderer tuto04;
	//public SpriteRenderer btnEnter04;	

	private float contar;
	private float keyTimer = 0f;


	void SetFalseAllObjects(){
		ballon01.enabled = false;
		ballon02.enabled = false;
		//btnEnterBallon.enabled = false;
		tuto01bg.enabled = false;
		tuto01.enabled = false;
		//btnEnter01.enabled = false;
		tuto02bg.enabled = false;
		tuto02.enabled = false;
		//btnEnter02.enabled = false;
		tuto03bg.enabled = false;
		tuto03.enabled = false;
		//btnEnter03.enabled = false;
		tuto04bg.enabled = false;
		tuto04.enabled = false;
		//btnEnter04.enabled = false;		
	}
	// Use this for initialization
	void Start () {
		contar = 0.0f;
		keyTimer = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene("Level1");
		}

		contar += Time.deltaTime;

		//ballon01
		if (contar >= 0.0f && contar < 4.0f){
			SetFalseAllObjects();
			ballon01.enabled = true;
			//btnEnterBallon.enabled = true;
			if(Input.GetKeyDown(KeyCode.Return)){
				if (keyTimer != Time.deltaTime) {
					contar = 4.0f;
					keyTimer = Time.deltaTime;
				}
			}
		}
		//ballon02
		if (contar >= 4.0f && contar < 9.0f){
			SetFalseAllObjects();
			ballon02.enabled = true;
			//btnEnterBallon.enabled = true;
			if(Input.GetKeyDown(KeyCode.Return)){
				if (keyTimer != Time.deltaTime) {
					contar = 9.0f;
					keyTimer = Time.deltaTime;
				}
			}			
		}
		//tuto01		
		if (contar >= 9.0f && contar < 14.0f){
			SetFalseAllObjects();
			tuto01bg.enabled = true;
			tuto01.enabled = true;
			//btnEnterBallon.enabled = true;
			//btnEnter01.enabled = true;
			if(Input.GetKeyDown(KeyCode.Return)){
				if (keyTimer != Time.deltaTime) {
					contar = 14.0f;
					keyTimer = Time.deltaTime;
				}
			}						
		}	
		//tuto02
		if (contar >= 14.0f && contar < 19.0f){
			SetFalseAllObjects();
			tuto02bg.enabled = true;
			tuto02.enabled = true;
			// btnEnter02.enabled = true;
			//btnEnterBallon.enabled = true;
			if(Input.GetKeyDown(KeyCode.Return)){
				if (keyTimer != Time.deltaTime) {
					contar = 19.0f;
					keyTimer = Time.deltaTime;
				}
			}						
		}	
		//tuto03
		if (contar >= 19.0f && contar < 24.0f){
			SetFalseAllObjects();
			tuto03bg.enabled = true;
			tuto03.enabled = true;
			//btnEnter03.enabled = true;
			//btnEnterBallon.enabled = true;
			if(Input.GetKeyDown(KeyCode.Return)){
				if (keyTimer != Time.deltaTime) {
					contar = 24.0f;
					keyTimer = Time.deltaTime;
				}
			}						
		}	
		//tuto04
		if (contar >= 24.0f && contar < 29.0f){
			SetFalseAllObjects();
			tuto04bg.enabled = true;
			tuto04.enabled = true;
			//btnEnter04.enabled = true;
			//btnEnterBallon.enabled = true;			
			if(Input.GetKeyDown(KeyCode.Return)){
				contar = 29.0f;
				keyTimer = Time.deltaTime;
			}						
		}
		if (contar > 29.0f){
			SceneManager.LoadScene("Level1");
		}						
	}

}
