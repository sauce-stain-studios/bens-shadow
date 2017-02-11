using UnityEngine;
using System.Collections;

public class ShadowController : MonoBehaviour {

	public float xSpeed = 3.0f;
	public float ySpeed = 3.0f;
	public float padding = 1.0f;
	private GameObject player;
	private bool playerOn; // check, need?

	float xmin;
	float xmax;
	float ymin;
	float ymax;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("left brick");
		playerOn = true;
		transform.position = player.transform.position;

	}

	public void toggleShadow() {
		if (playerOn) {
			PlayerController script = player.GetComponent<PlayerController> ();
			script.enabled = false;
			playerOn = false;
		} else {
			PlayerController script = player.GetComponent<PlayerController> ();
			script.enabled = true;
			playerOn = true;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (playerOn) {
			transform.position = new Vector3 (player.transform.position.x + 0.25f, player.transform.position.y + 0.25f,
				player.transform.position.z);
		}
		float vertical = Input.GetAxis("Vertical") * Time.deltaTime * ySpeed;
		float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * xSpeed;
		Vector3 movement = new Vector3 (horizontal, vertical, transform.position.z);
		transform.position += movement;
	}


}
