using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector2 startingVelocity = new Vector2(15, -21);
    public Vector3 startingPosition;


	// Use this for initialization
	void Start () {
        startingPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = startingVelocity; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
