using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable {

	public enum DoorState {Open, Closed};

	DoorState state;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void Activate () {
		if (state == DoorState.Open) {
			state = DoorState.Closed;
		} else {
			state = DoorState.Open;
		}
		Debug.Log(state);
	}

}
