using UnityEngine;
using System.Collections;

public class PlayAudioAndSelfDestruct : MonoBehaviour {
	public void PlayAudio() {
		audio.Play();
		Invoke("destroyMe", audio.clip.length);
	}

	void destroyMe() {
		Destroy(gameObject);
	}
}
