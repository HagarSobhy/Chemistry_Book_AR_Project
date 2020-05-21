using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H20Sound : MonoBehaviour {

   public AudioClip valvesfx;
	private AudioSource audioSource;
	

	RaycastHit hit;
	Ray ray;

	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {  
			
		Debug.Log ("Mouse is pressed down");

			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (ray , out hit)) {
				Debug.Log ("Object Hit is " + hit.collider.gameObject.name);
//hit.collider.gameObject.name == "sh1" || hit.collider.gameObject.name == "sh2"
				if ( hit.collider.gameObject.name == "h21" || hit.collider.gameObject.name == "h22") {
					Debug.Log ("we are here");
			    	audioSource.enabled = true;
		            if (!audioSource.isPlaying) {
			       	audioSource.clip = valvesfx;
		         	audioSource.Play ();
				}
				 } 

	}

		} 

	}
}