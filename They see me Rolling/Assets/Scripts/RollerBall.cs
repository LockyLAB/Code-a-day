using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerBall : MonoBehaviour {


	public bool KeyOne {
		get;
		private set;
	}
	public float jump = 1f;
	public float speed = 2f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");


		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed * Time.deltaTime);


	}
	public void GetKey(int keyNumber){
		switch (keyNumber) {
		case 1: 
			KeyOne = true;
			break;
		case 2:
			KeyOne = true;
			break;
		default:
			break;
		}
	}

	public bool HasKey(int keyNumber){
		switch (keyNumber) {
		case 1: 
			return KeyOne;
		case 2:
			return KeyOne;
		default:
			return false;
		}
	}
}