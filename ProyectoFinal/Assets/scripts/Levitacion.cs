using UnityEngine;
using System.Collections;
using System.Threading;

public class Levitacion : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		var aux = 0.5;
		if (col.gameObject.name == "Player"){
			for (int i = 0; i < 10; i++) {
				transform.position += new Vector3 (0f, 0.25f, 0f);
			}
		}
	}
}
