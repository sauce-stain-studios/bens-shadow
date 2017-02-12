using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float dampTime = 0.25f;

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
		Vector3 specificVector = new Vector3(target.position.x, target.position.y, transform.position.z);
   	transform.position = Vector3.Lerp(transform.position, specificVector, 1f * Time.deltaTime);
	}

}
