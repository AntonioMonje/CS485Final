using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMover : MonoBehaviour {
	public float moveSpeed = 1;
	public bool moveRight;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		

		rb2d = GetComponent<Rigidbody2D> ();

	}
	void Update(){
		InvokeRepeating("movement", 0.0f, 0.5f);	
	}
	// Update is called once per frame
	void movement() {
		moveSpeed = -moveSpeed;

			//rb2d.velocity = new Vector2 (-moveSpeed, rb2d.velocity.y);

	}
}
