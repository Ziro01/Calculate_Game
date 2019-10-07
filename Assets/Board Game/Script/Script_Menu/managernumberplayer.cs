using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class managernumberplayer : MonoBehaviour
{

    public static string numberPlayer;
    // void Start(){}
    // Update is called once per frame
    // void Update() { }
    public void toScene_SelectCha(string _numberPlayer){      //cha = Character  
        numberPlayer =_numberPlayer;                          //setting button {1_Player,2_Player,4_Player,4_Player}
        SceneManager.LoadScene("Choose_character");    

    }
}
