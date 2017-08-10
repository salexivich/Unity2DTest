using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
	public Rigidbody2D body;
	public Text countText;
	public Text winText;

	[Range(0.0f, 1000.0f)]
	public float movingForce;

	private int count;

	void Start()
	{
		count = 0;
		winText.text = "";
		UpdateCountText();
	}

	void FixedUpdate()
	{
		float horizontalValue = Input.GetAxis ("Horizontal");
		float verticalValue = Input.GetAxis ("Vertical");
		Vector2 force = new Vector2 (horizontalValue, verticalValue);
		force *= movingForce;
		body.AddForce (force);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		//Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
		if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);
			count++;
			UpdateCountText ();
			if (count >= 10) 
			{
				winText.text = "You win";
			}
		}
	}

	void UpdateCountText()
	{
		countText.text = "Count: " + count.ToString ();		
	}
}
