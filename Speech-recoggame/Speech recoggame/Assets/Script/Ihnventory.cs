using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ihnventory : MonoBehaviour {
	public Transform Papash;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Q))
		{  
			Papash.gameObject.SetActive(false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			Papash.gameObject.SetActive(true);
		}
	} 
}
