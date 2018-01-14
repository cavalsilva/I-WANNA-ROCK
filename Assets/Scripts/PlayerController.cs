using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

//Begin Remover Depois
using UnityEngine.UI;
//End Remover Depois

public class PlayerController : MonoBehaviour {


	public float speed;
	public float jumpHeight;
	public bool blockInputArrow = false;

	private Rigidbody2D rb2d;
	private float positionX;

	void Start()
	{
	}

	void Update()
	{
		positionX = Input.GetAxis ("Horizontal") * speed;

		if (positionX > 0) {
			gameObject.transform.localRotation = Quaternion.Euler (0, 0, 0);
		} else if (positionX < 0 ){
			gameObject.transform.localRotation = Quaternion.Euler (0, 180, 0);
		}
	}

	void FixedUpdate()
	{

		if (!blockInputArrow) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.position += Vector3.left * speed * Time.fixedDeltaTime;
				gameObject.GetComponent<SkeletonAnimation> ().AnimationName = "walk";

			} else if (Input.GetKey (KeyCode.RightArrow)) {
				transform.position += Vector3.right * speed * Time.fixedDeltaTime;
				gameObject.GetComponent<SkeletonAnimation> ().AnimationName = "walk";
			} else {
				gameObject.GetComponent<SkeletonAnimation> ().AnimationName = "idle";
			}


		}
	}

}
