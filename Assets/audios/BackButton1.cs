using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton1 : MonoBehaviour {

	public void change(string scenename){
		Application.LoadLevel(scenename);
	}
}
