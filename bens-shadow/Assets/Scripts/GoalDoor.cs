using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDoor : MonoBehaviour {

	private GameController gc;

	public bool shadowReached = false;
	public bool benReached = false;

	// Use this for initialization
	void Start () {
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}

	// Update is called once per frame
	void Update () {
		if (benReached && shadowReached) {
			wonGame();
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (gc.getCurrentDimension() == GameController.Dimension.Real) {
			benReached = true;
			gc.setDimensionShadow();
		} else {
			shadowReached = true;
			gc.setDimensionShadow();
		}
	}

	void wonGame() {
		Debug.Log("Ben and his shadow escaped the facility!");
	}
}
