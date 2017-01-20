using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraVida : MonoBehaviour {

	public Scrollbar HealthBar;
	public float Health = 0;

	public void Damage()
	{
		Health += 5;
		HealthBar.size = Health / 100f;
	}

}
