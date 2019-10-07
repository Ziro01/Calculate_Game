using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_HP : MonoBehaviour
{
    public Text HP;
    // Start is called before the first frame update
    // void Start() {}
    // Update is called once per frame
    // void Update(){ }

    public void Show_numberHP(int _id, int _number){
        HP.text = "ผู้เล่น:"+_id +" มีชีวิต: "+ _number;//.ToString();
    }
}
