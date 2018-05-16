using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float speed;
	public float lifetime;
	public int hp;
	public PlayerController player;
	public int death = 2;
	// Use this for initialization
	void Start () {
		hp = 0;
		rb2d = GetComponent<Rigidbody2D> ();	
		player = FindObjectOfType<PlayerController> ();
		if (player.transform.localScale.x < 0) {
			speed = -speed;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb2d.velocity = new Vector2 (speed, rb2d.velocity.y);	
		Updatehp ();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
		} 
	
		if (other.tag == "Boss") {
			Debug.Log (hp);
			Updatehp ();
			if (hp <= death ) {
				Destroy (other.gameObject);
				youWin ();
			} 
			else 
			{
				return;
			}
		} 
		if(other.tag != "Enemy" || other.tag != "Boss")
		{
			Destroy (gameObject, lifetime);
		}
	}
	void Updatehp()
	{
		hp++;
	}
	void youWin()
	{
		Application.LoadLevel (4);
	}
}
