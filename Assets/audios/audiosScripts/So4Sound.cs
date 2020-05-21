using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class So4Sound : MonoBehaviour {

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

				if ( hit.collider.gameObject.name == "so41" || hit.collider.gameObject.name == "so42" ) {
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