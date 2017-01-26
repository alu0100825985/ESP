using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class Llorar : MonoBehaviour {
	private AudioSource sonido;
	public int stop = 0;
	public AudioClip cryer;
	public float vol = 1.0f;

	void OnTriggerEnter(Collider other) {
		if (stop == 0) {
			sonido = GetComponent<AudioSource> ();
			sonido.PlayOneShot (cryer, vol);
			stop = 1;
		}
	}
}