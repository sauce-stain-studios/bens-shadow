using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	private GameController gc;

	public AudioSource audio;

 	public AudioClip RealDimensionMusic;
 	public AudioClip ShadowDimensionMusic;

	// Use this for initialization
	void Start () {
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
		changeMusic();
	}

	public void changeMusic () {
		if (gc.getCurrentDimension() == GameController.Dimension.Real) {
				audio.clip = RealDimensionMusic;
				audio.Play();
		} else {
				audio.clip = ShadowDimensionMusic;
				audio.Play();
		}
	}
}
