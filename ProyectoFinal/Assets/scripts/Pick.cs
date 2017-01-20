using UnityEngine;
using System.Collections;

public class Pick : MonoBehaviour {
	
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Player"){
			Obtener.picked = 1;
				Destroy (gameObject);
				Destroy (GameObject.FindWithTag ("Vacio"));
		}
	}
}

