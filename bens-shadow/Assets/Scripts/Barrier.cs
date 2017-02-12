using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour, IActivatable {
	private bool isOff;
	private float scrollDownVelocity = 0.0002f;
	public Vector3 movedBarrierPosition;
	// Use this for initialization

	private LayerMask mask;

	void Start () {
		Vector3 movedBarrierPosition = new Vector3 (-1.126446f, 0.7f, 0.39f);
		isOff = false;
	}

	void Update() {
		if (!isOff) {
			return;
		}
		Animate ();
		Debug.Log ("Animate enabled");
	}

	IEnumerator hi(){
		yield return new WaitForEndOfFrame();
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

	public void Animate () {
		if (transform.position == movedBarrierPosition)
			return;
		transform.position = Vector3.MoveTowards (transform.position, movedBarrierPosition, scrollDownVelocity);
	}
}
