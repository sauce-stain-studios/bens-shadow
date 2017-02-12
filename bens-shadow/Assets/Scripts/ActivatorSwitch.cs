using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorSwitch : MonoBehaviour, ISwitch {

  public GameObject activatableObject;
	private bool isOff;
	private bool visited;
	void Start () {
		visited = false;
	}

	void Update () {

 	}
	public void toggleSwitch() {
		isOff = !isOff;
	}

	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log ("hi");
		if (!visited) {
			visited = true;
			if (col.gameObject.tag == "Player") {
				Switch ();
			}
		} else {
			visited = false;
			if (col.gameObject.tag == "Player") {
				Switch ();
			}
		}
	}

  public void Switch() {
    if (activatableObject != null) {
      activatableObject.GetComponent<IActivatable>().Activate();
    }
  }

}
