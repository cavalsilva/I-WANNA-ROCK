using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;
public class EnemyIAController : MonoBehaviour {

	public Transform targetBegin;
	public Transform targetEnd;
	public GameObject player;

	public SpriteRenderer alert;

	bool teste = true;
	bool stop = false;
	bool enemyRightPosition;
	private float timeBullet = 0.0f;
	// Use this for initialization

	private int numBullet = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = 2 * Time.deltaTime;
		if (!stop){
			if (teste){
				enemyRightPosition = false;
				gameObject.transform.localRotation = Quaternion.Euler (0, 180, 0);
				gameObject.GetComponent<SkeletonAnimation> ().AnimationName = "walk";
				transform.position = Vector3.MoveTowards(transform.position, targetBegin.position, step);
				if(transform.position.x == targetBegin.position.x){
					teste = false;
				}
			} else if (!teste){
				enemyRightPosition = true;
				gameObject.transform.localRotation = Quaternion.Euler (0, 0, 0);
				gameObject.GetComponent<SkeletonAnimation> ().AnimationName = "walk";
				transform.position = Vector3.MoveTowards(transform.position, targetEnd.position, step);
				if(transform.position.x == targetEnd.position.x){
					teste = true;
				}			
			}

		}
	}

	void EsperePorXSegundos(float valor){
		while (timeBullet < valor){
			timeBullet += Time.deltaTime;
		}
		timeBullet = 0;
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (numBullet == 0){
			if( other.CompareTag("Player") && ( gameObject.CompareTag("CanFire") || gameObject.CompareTag("CanFireSpot")) ){
				alert.enabled = true;
				stop = true;

				gameObject.GetComponent<SkeletonAnimation> ().AnimationName = "alert";
				//gameObject.GetComponent<SkeletonAnimation> ().AnimationName = "crouch-off";
				StartCoroutine(Waiting());
				gameObject.GetComponent<SkeletonAnimation> ().AnimationName = "crouch-on";
				gameObject.GetComponent<SkeletonAnimation> ().AnimationName = "fire";

				StartCoroutine(Waiting());

				if (enemyRightPosition)
					//playerPosition.position = Vector3.MoveTowards(playerPosition.position, new Vector3(playerPosition.position.x+10,playerPosition.position.y,0),2);
					player.transform.position = Vector3.Lerp(player.transform.position, new Vector3(player.transform.position.x + 1.0f,player.transform.position.y,0),2);
				else
					//playerPosition.position = Vector3.MoveTowards(playerPosition.position, new Vector3(playerPosition.position.x-10,playerPosition.position.y,0),2);
					player.transform.position = Vector3.Lerp(player.transform.position, new Vector3(player.transform.position.x - 1.0f,player.transform.position.y,0),2);
					
				StartCoroutine(Waiting());
				numBullet = 1;
			}

			if (numBullet > 0) {
				if(teste)
					teste = false;
				else
					teste = true;

				numBullet = 0;
			}
		}else{
			alert.enabled = false;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		alert.enabled = false;
	}

	IEnumerator Waiting(){
		yield return new WaitForSeconds(1);
		EnableMovement();
	}

	void EnableMovement(){
		stop = false;
	}
}
