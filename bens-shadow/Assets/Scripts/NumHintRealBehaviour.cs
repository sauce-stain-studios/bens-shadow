using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumHintRealBehaviour : MonoBehaviour {

	private GameController gc;
	private GameObject hint;
	private bool destroyed;
	// Use this for initialization
	void Start () {
		hint = gameObject;
		destroyed = true;
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();

	}
		

	// Update is called once per frame
	void Update () {
		if (gc.getCurrentDimension() == GameController.Dimension.Real) {
			gameObject.GetComponent<Renderer>().enabled = true;
		} else {
			gameObject.GetComponent<Renderer>().enabled = false;
		}
}
}
