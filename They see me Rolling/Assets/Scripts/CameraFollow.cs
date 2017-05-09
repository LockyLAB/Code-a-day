﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


	public GameObject player;

	private Vector3 offset;


	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
		



	// Update is called once at the end per frame
	void LateUpdate () {

		transform.position = player.transform.position + offset;
	}




}
