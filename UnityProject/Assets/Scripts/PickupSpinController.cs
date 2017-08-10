using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpinController : MonoBehaviour {
	private Rigidbody2D body;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
		body.AddTorque (30.0f);
	}

	void FixedUpdate()
	{
	}
}
