using UnityEngine;
using System.Collections;

public class AbrirVR : MonoBehaviour {

	public void Open() {
		if (Obtener.picked == 1) {
			Destroy (gameObject);
		}
	}
}
