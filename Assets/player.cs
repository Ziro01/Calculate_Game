using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	// Use this for initialization
	public GameObject ObjectB;
	public Transform PositionB;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.S)){
			shoot();
		}
	}

	public void shoot(){
        Debug.Log("shoot");
		// Instantiate(builnt, transform.position, transform.rotation); 
		// Instantiate(builnt, transform.position, transform.rotation); 
	}

	void Birth(){   //จุดปล่อย อุกาบาต
		GameObject TestObject =  Instantiate(ObjectB);
		TestObject .transform.SetParent(PositionB);
		TestObject .transform.position = PositionB.transform.position;
	}
}
