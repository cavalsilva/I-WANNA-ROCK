using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVisionController : MonoBehaviour {

//	public float maxRayDistance = 150;

	//public Vector2 direction;

	//Vector2 position = transform.position;
//	Vector2 direction = Vector2.left;
	// float distance = 150.0f;



	// Use this for initialization
	void Start () {



	}

	void FixedUpdate(){

	
		//Debug.DrawRay(this.gameObject.transform.position, direction * distance, Color.red);

		//RaycastHit2D hit = Physics2D.Raycast(this.gameObject.transform.position, direction, Mathf.Infinity);
		//if (hit.collider.gameObject.name == "Player") {
	//		Debug.Log ("PERIOUFGHJFGVFGHJKDF");
	//	}

	}

	// Update is called once per frame
	void Update () {

		//Cast a ray in the direction specified in the inspector.
		//RaycastHit2D hit = Physics2D.Raycast(this.gameObject.transform.position, direction);

		//If something was hit.
		//if (hit.collider != null)
		//{
			//If the object hit is less than or equal to 6 units away from this object.
		//	if (hit.distance <= 150.0f && hit.collider.gameObject.name == "Player")
		//	{
		//		Debug.Log("Enemy In Range!");
		//	}
		//}


	}

}