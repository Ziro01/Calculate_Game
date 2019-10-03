using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class data_Chalacter : MonoBehaviour {
	Modeldata_Chalacter date_Cha = new Modeldata_Chalacter();
    public Text txt_name,txt_hp;
	public int nums =1000;

	public string  enter_name;
	public int 	   enter_hp;
	// Use this for initialization
	void Start () {
		date_Cha = new Modeldata_Chalacter();
		date_Cha.name = enter_name;
		date_Cha.hp   = enter_hp;

		Debug.Log("[] = "+date_Cha.num[5]);


		date_Cha.Show_Data();

        show_Data();
	}
	
	// Update is called once per frame
	void Update () {	
	}

	public void show_Data(){
		txt_name.text = date_Cha.name;
		txt_hp.text = date_Cha.hp.ToString();
	}
}
