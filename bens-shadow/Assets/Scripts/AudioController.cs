using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	private GameController gc;

	public AudioSource audio;

 	public AudioClip RealDimensionMusic;
 	public AudioClip ShadowDimensionMusic;
	private float pausedTime;

	// Use this for initialization
	void Start () {
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
		// pausedTime = 0;
		changeMusic();
	}

	public void changeMusic () {
		float oldTime = audio.time;
		if (gc.getCurrentDimension() == GameController.Dimension.Real) {
			audio.clip = RealDimensionMusic;
		} else {
			audio.clip = ShadowDimensionMusic;
		}
		audio.Play();
	}

	void Update() {
		// if (pausedTime <= 170) {
		// 	pausedTime += Time.deltaTime;
		// } else {
		// 	pausedTime = 0;
		// }
		// Debug.Log (audio.time);
	}
}
