using UnityEngine;
using System.Collections;

public class Pick : MonoBehaviour {
	
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Player"){
			if (Input.GetKeyDown ("e")) {
				Destroy (gameObject);
				Destroy (GameObject.FindWithTag ("Vacio"));
			}
		}
	}
}

