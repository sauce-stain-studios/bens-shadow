using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour, IActivatable {
	private bool isOff;
	// Use this for initialization
	void Start () {
		isOff = false;
	}


	public void Activate() {
		isOff = !isOff;
		Debug.Log (isOff);
		this.GetComponent<BoxCollider2D> ().enabled = !isOff;
	}
}
