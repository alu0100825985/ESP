using UnityEngine;
using System.Collections;

public class Pick : MonoBehaviour {
	
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Player"){
				Destroy (gameObject);
				Destroy (GameObject.FindWithTag ("Vacio"));
		}
	}
}

