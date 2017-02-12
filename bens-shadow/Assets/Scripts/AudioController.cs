using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	private GameController gc;

	public AudioSource audioSource;
	public AudioSource stepSoundSource;

 	public AudioClip RealDimensionMusic;
 	public AudioClip ShadowDimensionMusic;
	public AudioClip StepSoundClip;

	public bool CanPlayStep = true;

	void Start () {
		gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
		stepSoundSource.clip = StepSoundClip;
		changeMusic();
	}

	void FixedUpdate () {
		if (CanPlayStep && !stepSoundSource.isPlaying && (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis ("Vertical") != 0)) {
			stepSoundSource.Play ();
			CanPlayStep = false;
			StartCoroutine(PlayDelayedSound(0.3f - 0.1f * (new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical")).magnitude)));
		}
	}

	IEnumerator PlayDelayedSound(float delay){
		yield return new WaitForSecondsRealtime (delay);
		CanPlayStep = true;
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
