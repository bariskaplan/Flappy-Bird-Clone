﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

	public float speed = 10f;

	private Rigidbody2D rigidbody2d;

	void Start () {
		rigidbody2d = GetComponent<Rigidbody2D>();
		rigidbody2d.velocity = new Vector2(-speed, 0f);
	}
		
	

}
