using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NH3Sound : MonoBehaviour {
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

				if ( hit.collider.gameObject.name == "sp1" || hit.collider.gameObject.name == "sp2") {
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