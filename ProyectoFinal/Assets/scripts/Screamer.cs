using UnityEngine;
using System.Collections;
using System.Threading;
using UnityEngine.UI;

public class Screamer : MonoBehaviour {

	public GameObject gameOver;
	public GameObject luz;
	public GameObject llave;
	private AudioSource sonido;
	public int stop = 0;
	public AudioClip grito;
	public float vol = 1.0f;
	float currentTime = 0f;
	float step = 0.1f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator TimerRoutine(){
		while (currentTime < 1.5) {
			yield return new WaitForSeconds (step);
			currentTime += step;
		}
		gameOver.SetActive (false);
		gameObject.SetActive (false);
		luz.GetComponent<Light>().enabled = true;
		llave.SetActive (true);

	} 



	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Player") {
			gameOver.SetActive (true);
			if (stop == 0) {
				sonido = GetComponent<AudioSource> ();
				sonido.PlayOneShot (grito, vol);
				stop = 1;
			}
			StartCoroutine (TimerRoutine());
		}
	}
}
