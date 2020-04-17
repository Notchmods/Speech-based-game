using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsFX : MonoBehaviour {

	public ParticleSystem PS;
	public AudioSource AS;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			PS.Play();
			AS.Play();
		}
	}
}
