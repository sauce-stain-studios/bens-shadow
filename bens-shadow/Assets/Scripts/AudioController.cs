using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	private GameController gc;

	public AudioSource audioSource;

 	public AudioClip RealDimensionMusic;
 	public AudioClip ShadowDimensionMusic;

	void Start () {
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
		changeMusic();
	}

	public void changeMusic () {
		float oldTime = audioSource.time;
		if (gc.getCurrentDimension() == GameController.Dimension.Real) {
			audioSource.clip = RealDimensionMusic;
		} else {
			audioSource.clip = ShadowDimensionMusic;
		}
		audioSource.time = oldTime;
		audioSource.Play();
	}

	void Update() {
	}
}
