using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumHintShadBehaviour : MonoBehaviour {

	private GameController gc;
	// Use this for initialization
	void Start () {
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();

	}


	// Update is called once per frame
	void Update () {
		if (gc.getCurrentDimension() == GameController.Dimension.Shadow) {
			gameObject.GetComponent<Renderer>().enabled = true;
		} else {
			gameObject.GetComponent<Renderer>().enabled = false;

		}
	}
}