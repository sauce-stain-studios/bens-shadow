using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public enum Dimension { Real, Shadow };

	Dimension currentDimension;
	AudioController audioController;

	public bool debugMode;

	// Use this for initialization
	void Start () {
		currentDimension = Dimension.Real;
		audioController = GameObject.FindWithTag("AudioController").GetComponent<AudioController>();
	}

	void FixedUpdate() {
		if (debugMode) {
			// Dimension Switch Debug
			if (Input.GetKeyDown (KeyCode.Space)) {
				if (currentDimension == Dimension.Real) {
					setDimensionShadow();
				} else {
					setDimensionReal();
				}
			}
		}
	}

	public void setDimensionReal() {
		currentDimension = Dimension.Real;
		audioController.changeMusic();
	}

	public void setDimensionShadow() {
		currentDimension = Dimension.Shadow;
		audioController.changeMusic();
	}

	public Dimension getCurrentDimension() {
		return currentDimension;
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.R)) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
