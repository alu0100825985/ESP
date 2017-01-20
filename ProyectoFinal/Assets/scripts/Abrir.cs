using UnityEngine;
using System.Collections;

public class Abrir : MonoBehaviour {
	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Player"){
			if (Obtener.picked == 1) {
				Destroy (gameObject);
			}
		}
	}
}
