using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingText : MonoBehaviour {

	public GameObject posicaoFinal;
	public GameObject texto1;
	public Text t1;
	public Text txtTheEnd;
	public Image buttonPlay;
	public Image buttonCredits;
	public float duration = 60;

	public bool flagFadeOutText;

	private Color finalColor = Color.white;
	private bool bTxtTheEnd = false;

	void Start(){
		if(txtTheEnd != null){
			finalColor.a = Mathf.Lerp(0,0,0);
			txtTheEnd.color = finalColor;
			bTxtTheEnd = true;
		}
		if (buttonPlay != null){
			buttonPlay.color = finalColor;
		}
		if (buttonCredits != null){
			buttonCredits.color = finalColor;
		}
	}


	// Update is called once per frame
	void Update () {
		Color myCor = Color.white;
		float step = 1;
		texto1.transform.position = Vector3.MoveTowards(texto1.transform.position,posicaoFinal.transform.position,step);

		if(flagFadeOutText){
			if(texto1.transform.position.y == posicaoFinal.transform.position.y){
					float ratio = Time.time/duration;
					myCor.a = Mathf.Lerp(1,0,ratio);
					t1.color = myCor;

					if(ratio >= 1 && bTxtTheEnd){
						finalColor.a = Mathf.Lerp(1,0,ratio*-1);
						txtTheEnd.color = finalColor;


						if (buttonPlay != null){
							buttonPlay.color = finalColor;						
						}
						if (buttonCredits != null){
							buttonCredits.color = finalColor;						
						}
						texto1.SetActive(false);
			
					}
			}
		}

	}
}
