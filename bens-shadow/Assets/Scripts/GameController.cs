using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public enum Dimension { Real, Shadow };

	Dimension currentDimension;
	AudioController audioSource;

	public bool debugMode;

	// Use this for initialization
	void Start () {
		currentDimension = Dimension.Real;
		audioSource = GameObject.FindWithTag("AudioController").GetComponent<AudioController>();
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
		audioSource.changeMusic();
	}

	public void setDimensionShadow() {
		currentDimension = Dimension.Shadow;
		audioSource.changeMusic();
	}

	public Dimension getCurrentDimension() {
		return currentDimension;
	}

}
