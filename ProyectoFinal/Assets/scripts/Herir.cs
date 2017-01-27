using UnityEngine;
using System.Collections;

public class Herir : MonoBehaviour {

	private AudioSource sonido;
	public int stop = 0;
	public AudioClip grito;
	public float vol = 1.0f;

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Player"){
			if (stop == 0) {
				sonido = GetComponent<AudioSource> ();
				sonido.PlayOneShot (grito, vol);
				GameObject.FindWithTag("Player").GetComponent<BarraVida>().Damage();
				stop = 1;
			}
		}
	}
}
