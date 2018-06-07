﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCorridor : MonoBehaviour {

	public GameObject corridor;
	public int numberOfCorridors;
	public float zOffset;
	private Vector3 position;

	// Use this for initialization
	void Start () {
		while (numberOfCorridors > 0)
		{
			if(position == null)
			{
				position = Vector3.zero;
			}
			Instantiate (corridor, position, Quaternion.Euler (Vector3.zero));
			position.z += zOffset;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
