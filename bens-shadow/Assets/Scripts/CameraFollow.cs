using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float xMin, xMax, yMin, yMax;

	private GameController gc;
	private Transform benLocation;
	private Transform shadowLocation;

	void Start () {
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
		benLocation = GameObject.Find ("Ben").transform;
		shadowLocation = GameObject.Find ("Shadow").transform;
	}

	void LateUpdate () {
		Transform target = benLocation;
		if (gc.getCurrentDimension() == GameController.Dimension.Shadow) {
			target = shadowLocation;
		}
		transform.position = new Vector3 (
			Mathf.Clamp (target.position.x, xMin, xMax),
			Mathf.Clamp (target.position.y, yMin, yMax),
			transform.position.z
		);
	}

}
