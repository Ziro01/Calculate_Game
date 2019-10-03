using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modeldata_Chalacter{
	public string name;
	public int hp;
	public int[] num = {1,2,3,4,5,6,7,8,9};


	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

	public void Show_Data(){
		hp += 50;
		Debug.LogFormat("name = {0},hp = {1}",name,hp);
	}
}
