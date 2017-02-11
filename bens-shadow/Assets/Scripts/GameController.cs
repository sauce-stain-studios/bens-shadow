using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public enum Dimension { Real, Shadow };

	Dimension currentDimension;

	// Use this for initialization
	void Start () {
		currentDimension = Dimension.Real;
	}

	public void setDimensionReal() {
		currentDimension = Dimension.Real;
	}

	public void setDimensionShadow() {
		currentDimension = Dimension.Shadow;
	}

	public Dimension getCurrentDimension() {
		return currentDimension;
	}

}
