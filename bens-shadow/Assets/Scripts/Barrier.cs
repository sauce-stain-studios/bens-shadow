using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour, IActivatable {
	private bool isOff;
	private float scrollDownVelocity = 0.02f;
	public Vector3 newPos;
	// Use this for initialization

	private LayerMask mask;

	private Vector3 targetLoc;
	public GameObject targetObj;

	void Start () {
		isOff = false;
		targetLoc = new Vector3 (targetObj.gameObject.transform.position.x, targetObj.gameObject.transform.position.y, targetObj.gameObject.transform.position.z);
	}

	void Update() {
		if (isOff) {
			animate ();
		}
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

	public void animate () {
		/*Debug.Log ("Position before: " + transform.position.y);
		float wallHeight = transform.lossyScale.y;
		transform.position += Vector3.down * scrollDownVelocity * Time.deltaTime;
		Debug.Log ("Position after " + transform.position.y);*/
		transform.position = Vector3.MoveTowards (transform.position, targetLoc, scrollDownVelocity);
	}

//	void OnCollisionEnter2D(Collision2D col){
//		if (col.transform.tag == "Player") {
//			//GetComponent<Collider2D> ().enabled = false;
//		}
//	}


}
