using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraVida : MonoBehaviour {

	public Scrollbar HealthBar;
	public float Health = 0;
	public GameObject GameOver;

	public void Damage()
	{
		Health += 25;
		HealthBar.size = Health / 100f;
		if (HealthBar.size == 1f) {
			GameOver.SetActive (true);
		}
	}

}
