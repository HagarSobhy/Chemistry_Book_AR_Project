using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsStartButton : MonoBehaviour {

	public void change(string scenename){
		Application.LoadLevel(scenename);
	}
}
