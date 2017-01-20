using UnityEngine;
using System.Collections;

public class Herir : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Player"){
			GameObject.FindWithTag("Player").GetComponent<BarraVida>().Damage();
			Debug.Log("hola");
		}
	}
}
