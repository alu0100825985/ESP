using UnityEngine;
using System.Collections;

public class PickVR : MonoBehaviour {

	public void Coger() {
		Debug.Log ("Hola");
		Obtener.picked = 1;
		Destroy (gameObject);
		Destroy (GameObject.FindWithTag ("Vacio"));
	}
}
