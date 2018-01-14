using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

	public float timerMaxValue = 30.0f;
	public float timerValue;
	public Animator eyeAnimator;

	private bool stop = false;
	SceneController scene;

	void Start()
	{
		ResetTimer ();
		PlayTimer ();

		eyeAnimator.SetBool ("IsEyeStopped", false);

		scene = new SceneController ();

	}

	void FixedUpdate () 
	{
		if (!stop) 
		{
			if (timerValue > 0) 
			{
				timerValue -= Time.fixedDeltaTime;
			} else 
			{
				StopTimer ();
				scene.LoadGameOver ();
			}
		}
	}

	public void ResetTimer()
	{
		timerValue = timerMaxValue;
		StopTimer ();
	}

	public void PlayTimer()
	{
		stop = false;
		eyeAnimator.SetBool ("IsEyeStopped", false);
	}

	public void StopTimer()
	{
		stop = true;
		eyeAnimator.SetBool ("IsEyeStopped", true);
	}

}
