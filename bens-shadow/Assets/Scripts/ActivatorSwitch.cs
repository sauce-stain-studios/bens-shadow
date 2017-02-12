using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorSwitch : MonoBehaviour, ISwitch {

  public GameObject activatableObject;
  public Animator animator;
  
	private bool isOff;
	private bool visited = false;

	void Start () {
    animator = GetComponent<Animator>();
	}

	void Update () {
    animator.SetBool("switchOn", !isOff);
 	}

	void toggleSwitch() {
		isOff = !isOff;
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (!visited) {
			visited = true;
			Switch();
		}
	}

  void OnTriggerExit2D(Collider2D col) {
    visited = false;
  }

  public void Switch() {
    toggleSwitch();
    if (activatableObject != null) {
      activatableObject.GetComponent<IActivatable>().Activate();
    }
  }

}
