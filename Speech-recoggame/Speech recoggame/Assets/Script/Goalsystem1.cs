using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goalsystem1 : MonoBehaviour {

	public Text Goal1;
	int Numbergoal1;

	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Memes")
		{
			Nasser();
		}
	}

	public void Nasser()
	{
		Numbergoal1 += 1;	 
		Goal1.text = Numbergoal1.ToString();
		Debug.Log("goals"); 
	}
}
