using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting_btn : MonoBehaviour {
           //เรียงลำดับ
	public Button btn_1,btn_2,btn_3,btn_4;
	[Space(15)]
	public Text txt_1,txt_2,txt_3,txt_4,txt_Total;
	// [Space(15)]
    public int num_1,num_2,num_3,num_4;
	// [Space(15)]
	public int min,max;
	private int numC_1,numC_2,numC_3,numC_4;
	private int  numTotal ,num_Answer ,numconut;
	// Use this for initialization

	public 
	void Start () {
		set_btn();
		calculate_num();

		btn_1.onClick.AddListener(()=>{  Inspect(1); });
		btn_2.onClick.AddListener(()=>{  Inspect(1); });
		btn_3.onClick.AddListener(()=>{  Inspect(1); });
		btn_4.onClick.AddListener(()=>{  Inspect(1); });
	}
	
	// Update is called once per frame
	void Update () {}

	public void set_btn(){
		    //show number in button
		txt_1.text = num_1.ToString();
		txt_2.text = num_2.ToString();
		txt_3.text = num_3.ToString();
		txt_4.text = num_4.ToString();

		// txt_Total.text = numTotal.ToString();
	}
	public void calculate_num(){   //ตั้งคำถาม
        numC_1 = number_Question(min,max);
		numC_2 = number_Question(min,max);
		numC_3 = number_Question(min,max);
		numC_4 = number_Question(min,max);
		// Debug.Log(numTotal +" +"+ numC_1 +" +"+ numC_2 +" +"+ numC_3 +" +"+ numC_4);
		numTotal = numC_1 + numC_2 + numC_3 + numC_4;

		txt_Total.text = numTotal.ToString();
	}

	public void Inspect(int _num){  //ตรวจคำตอบ
		if(numconut <= 3){
			num_Answer += _num;
			numconut += 1;
			Debug.Log("numconut = "+numconut);
		}
		else {
			
			Debug.Log(" end == "+numconut);
			Debug.Log("numconut = "+numconut);

			if(num_Answer == numTotal){
				//win game
			}
			else{
				//lost game
			}
		}
	}

	static int number_Question(int _min,int _max){   //สุ่มเลข
		int number;
		number = Random.Range(_min,_max);
		
		return number;
	}
}
