using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goalsystemtyu : MonoBehaviour {

	public Text Goaltyu;
	int Leningoals;

	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Memes")
		{
			Iraq();
		}
	}

	public void Iraq()
	{
		Leningoals += 1;
		Goaltyu.text = Leningoals.ToString();
		Debug.Log("goals");
	}
}
