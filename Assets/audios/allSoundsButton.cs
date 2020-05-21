using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class allSoundsButton : MonoBehaviour {

	public AudioClip valvesfx;
	private AudioSource audioSource;
	public Button SoundButton ;
	

	RaycastHit hit;
	Ray ray;

	void Start () {
		GameObject GM = GameObject.Find("GM");
		Button btn = SoundButton.GetComponent<Button>();
		audioSource = gameObject.GetComponent<AudioSource> ();
		//btn.onClick.AddListener(TaskOnClick);
	}



	void Update ()
	{
		Button btn = SoundButton.GetComponent<Button>();
		if (Input.GetMouseButtonDown (0)) {  
			
		Debug.Log ("Mouse is pressed down");

			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (ray , out hit)) {
					Debug.Log ("Object Hit is " + hit.collider.gameObject.name);
					if(gameObject.name == "Sphere"){
						btn.onClick.AddListener(TaskOnClick);
					}
					

				
				 } 

	}

		} 

	

	public void TaskOnClick(){
				Debug.Log ("we are here");
			    audioSource.enabled = true;
		        if (!audioSource.isPlaying) {
			       	audioSource.clip = valvesfx;
		         	audioSource.Play ();
				}
	}
}