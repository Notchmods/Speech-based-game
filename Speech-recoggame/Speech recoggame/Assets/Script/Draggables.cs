using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggables : MonoBehaviour {

	bool touched = false;
	bool Playernear = false;
	bool Iscarried = false;
	public Transform FPSC;
	public Transform Cameralite;	 
	
	// Update is called once per frame
	void Update () {
		float distancesm = Vector3.Distance(gameObject.transform.position, FPSC.position);
		if (distancesm <= 10f)
		{
			Playernear = true;
		}
		else
		{
			Playernear = false;
		}

		if(Playernear && Input.GetButtonDown("Use")) 
		{
			GetComponent<Rigidbody>().isKinematic = true;
			transform.parent = Cameralite;
			Iscarried = true;
		}
		if (Iscarried)
		{
			if (touched)
			{
				GetComponent<Rigidbody>().isKinematic = false;
				transform.parent = null;
				Iscarried = false;
				touched = false;
			}
		}
		if (Input.GetMouseButtonDown(0))
		{
			GetComponent<Rigidbody>().isKinematic = false;
			transform.parent = null;
			Iscarried = false;
			GetComponent<Rigidbody>().AddForce(Cameralite.forward * 250f);
		}
		else
		{
			if (Input.GetMouseButtonDown(1))
			{
				GetComponent<Rigidbody>().isKinematic = false;
				transform.parent = null;
				Iscarried = false;
				GetComponent<Rigidbody>().AddForce(Cameralite.forward * 0f);
			}
		}
	}

	public void OnTriggerEnter()
	{
		if (Iscarried)
		{
			touched = true; 
		}	
	}
}
