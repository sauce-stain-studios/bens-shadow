using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	private GameController gc;

	public AudioSource audioSource;

 	public AudioClip RealDimensionMusic;
 	public AudioClip ShadowDimensionMusic;

	// Use this for initialization
	void Start () {
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
		changeMusic();
	}

	public void changeMusic () {
		if (gc.getCurrentDimension() == GameController.Dimension.Real) {
				audioSource.clip = RealDimensionMusic;
				audioSource.Play();
		} else {
				audioSource.clip = ShadowDimensionMusic;
				audioSource.Play();
		}
	}
}
