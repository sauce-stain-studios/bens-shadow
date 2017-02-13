using UnityEngine;
using System.Collections;

public class LevelManager1 : MonoBehaviour {
	private LevelManager gc;


	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	void Update() {
		if (Input.GetKey ("joystick button 0")) {
			Application.LoadLevel ("Story Scene");
		}
	}

}
