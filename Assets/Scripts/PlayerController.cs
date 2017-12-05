using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private string question;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		question = "Volume = 4/3*πr^3";
		countText.text = question;
//		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("cone"))
		{
			other.gameObject.SetActive (false);
//			count = count + 5;
			countText.text = "Volume =1/3*Ah";
//			SetCountText ("hello");
		} else if (other.gameObject.CompareTag ("cube"))
		{
			other.gameObject.SetActive (false);
			countText.text = "Volume = A*h";
//			count = count + 5;
//			SetCountText ("hello");
		}
		else if (other.gameObject.CompareTag ("pyramid"))
		{
			other.gameObject.SetActive (false);
			question = "Volume: hello";
//			count = count + 5;
//			SetCountText ("hello");
		}
		else if (other.gameObject.CompareTag ("sphere"))
		{
			other.gameObject.SetActive (false);
			countText.text = "Volume = s^3";
//			count = count + 5;
//			SetCountText ("hello");


		}
		else if (other.gameObject.CompareTag ("cylinder"))
		{
			other.gameObject.SetActive (false);
			countText.text = "Volume = 1/3*Ah";
//			count = count + 5;
//			SetCountText ("hello");
		}
	}

//	Add text
//	void SetCountText (string challenge)
//	{
//		countText.text = "Volume: " + challenge;
//		if (count >= 15)
//		{
//			winText.text = "You Win!";
//		}
//	}

}
