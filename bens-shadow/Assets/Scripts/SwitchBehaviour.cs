using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehaviour : MonoBehaviour {
	bool canSwitch;
	bool lights;

	void Start() {
		canSwitch = true;
		lights = false;
	}

	void OnTriggerEnter2D(Collider2D col) {
		// http://answers.unity3d.com/questions/777179/ontriggerenterexit-are-firing-too-quickly-and-chan.html
		if(canSwitch && !lights && col.CompareTag("Shadow"))
		{
			lights = true;//turn lights on
			canSwitch = false; //change boolean to false
			Debug.Log ("hi");
			ShadowController script = col.gameObject.GetComponent<ShadowController>();
			script.toggleShadow();
		}
		else if(canSwitch && lights && col.CompareTag("Shadow"))
		{
			Debug.Log ("Hello");
			lights = false;
			canSwitch = false;
			//turn lights off
			ShadowController script = col.gameObject.GetComponent<ShadowController>();
			script.toggleShadow();
		}

	}
	void OnTriggerExit()
	{

		StartCoroutine("DelayTimer");
	}

	IEnumerator DelayTimer()
	{
		yield return new WaitForSeconds(1f); //or how many seconds you want it to be
		canSwitch = true; //change to true
	}
	/*
	void OnCollisionEnter2D(Collision2D col) {
		Debug.Log ("hi");
	}
	*/
	
	// Update is called once per frame
	void Update () {
		
	}
}
