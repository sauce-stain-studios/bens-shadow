using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private GameController gc;

	public GameController.Dimension activeDimension;

	public float xSpeed = 3.0f;
	public float ySpeed = 3.0f;
	public float padding = 1.0f;

	float xmin;
	float xmax;
	float ymin;
	float ymax;

	// Use this for initialization
	void Start () {
		// Initialize Reference to GameController
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();

		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
		Vector3 rightMost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
		Vector3 upMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distance));
		Vector3 downMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
		xmin = leftMost.x + padding;
		xmax = rightMost.x - padding;
		ymin = downMost.y + padding;
		ymax = upMost.y - padding;

		if (activeDimension == GameController.Dimension.Shadow) {
			GetComponent<SpriteRenderer>().enabled = false;
		}

	}

	// Update is called once per frame
	void FixedUpdate () {
		if (gc.getCurrentDimension() == activeDimension) {
			GetComponent<SpriteRenderer>().enabled = true;
			float vertical = Input.GetAxis("Vertical") * Time.deltaTime * ySpeed;
			float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * xSpeed;
			Vector3 movement = new Vector3 (horizontal, vertical, transform.position.z);
			transform.position += movement;
		}
	}
}
