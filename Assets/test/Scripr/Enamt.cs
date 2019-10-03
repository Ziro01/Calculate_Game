using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enamt : MonoBehaviour {
	Vector3 Enamy;                //position enamy
	float speedEnamy = .01f;     //speed
	public bool direction_enamy;    //move direction

	// Use this for initialization
	// void Start () {}
	
	// Update is called once per frame
	// void Update () {}
	public void FixedUpdate(){
		switch(direction_enamy){
			case true:
			Enamy = transform.position;
			Enamy.x += speedEnamy;
			transform.position = Enamy;
			break;

			default:
			Enamy = transform.position;
			Enamy.x -= speedEnamy;
			transform.position = Enamy;
			break;

		}
	}

private void OnCollisionEnter2D(Collision2D other) {
	if(other.gameObject.CompareTag("Player")){
		Destroy(gameObject);
	}

	
		
	}
}
