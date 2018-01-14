using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySight : MonoBehaviour {

	public float distanciaInimigo; //Por default está 11.0f
	public SpriteRenderer exclamacao;

	public Transform firePoint;
	public GameObject tiroInimigo;

	//10:21

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit2D hit = Physics2D.Raycast(this.transform.position, Vector3.left, distanciaInimigo); // 0.5f raycast length
//		Debug.DrawRay(this.transform.position, Vector3.left * distanciaInimigo);

		if (hit.collider != null && hit.collider.gameObject.name == "Player") {
			// Debug.Log (hit.collider.gameObject.name);
			Debug.Log ("Achei o jogador");
			exclamacao.enabled = true;
			// Instantiate( tiroInimigo, firePoint.position, firePoint.rotation);
			// GameObject go = (GameObject)Instantiate(tiroInimigo);
		
		} 
		else {			
			exclamacao.enabled = false;
		}
//		else
//		{
//			Debug.Log("False");
//		}

	}


}
