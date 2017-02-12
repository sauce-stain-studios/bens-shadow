using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour, IActivatable {
	private bool isOff;
	// Use this for initialization
	void Start () {
		isOff = false;
	}

	public void Activate() {
		isOff = !isOff;
		if (isOff) {
			this.GetComponent<BoxCollider2D> ().enabled = false;
			this.GetComponent<SpriteRenderer> ().enabled = false;
		} else {
			this.GetComponent<BoxCollider2D> ().enabled = true;
			this.GetComponent<SpriteRenderer> ().enabled = true;
		}

	}
}
