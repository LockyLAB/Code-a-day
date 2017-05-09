using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	public int keyNumber;
	public bool triggered;

	void OnTriggerEnter (Collider col){
		if(col.tag == "Player" && col.GetComponent <RollerBall> ().HasKey(keyNumber))
			gameObject.SetActive (false);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
