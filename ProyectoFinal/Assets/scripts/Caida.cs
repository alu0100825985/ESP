using UnityEngine;
using System.Collections;

public class Caida : MonoBehaviour {

	public GameObject cabeza1;
	public GameObject cabeza2;
	public Rigidbody rb;
	public Rigidbody rb2;
	// Use this for initialization
	void Start () {
		rb = cabeza1.GetComponent<Rigidbody>();
		rb2 = cabeza2.GetComponent<Rigidbody>();
	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Player") {
			rb.useGravity = true;
			rb2.useGravity = true;
 		}
	}

}