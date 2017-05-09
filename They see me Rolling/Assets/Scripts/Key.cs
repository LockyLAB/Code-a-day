using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
	public int keyNumber;
	void OnTriggerEnter (Collider col){
		if(col.tag == "Player"){
			col.GetComponent<RollerBall> ().GetKey(keyNumber);

			gameObject.SetActive (false);
		}


	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
