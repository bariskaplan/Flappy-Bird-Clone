using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rigidBody2d;

	public float jumpRate = 5f;

	void Start () {
		rigidBody2d = GetComponent<Rigidbody2D>();
	}
	
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			rigidBody2d.AddForce(Vector2.up * jumpRate);
		}
	}
}
