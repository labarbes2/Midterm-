﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    Rigidbody2D rigidBody;
    public float speed = 6;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        x = x * speed;
        rigidBody.velocity = new Vector2(x, 0);
		
	}
}
