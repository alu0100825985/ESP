using UnityEngine;
using System.Collections;

public class Ganar : MonoBehaviour {

	private AudioSource sonido;
	public int stop = 0;
	public AudioClip bocina;
	public float vol = 1.0f;
	public GameObject Win;

	void OnTriggerEnter(Collider other) {
		if (stop == 0) {
			sonido = GetComponent<AudioSource> ();
			sonido.PlayOneShot (bocina, vol);
			stop = 1;
			Win.SetActive (true);
		}
	}
}
