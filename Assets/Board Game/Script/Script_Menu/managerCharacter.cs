using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class managerCharacter : MonoBehaviour
{
    [Header("Part enter Data")]
    public List <Sprite> set_character = new List <Sprite>();   //show character
    [Space(15)]
    public static List <int> Set_id = new List <int>();                //set data character
    [Space(15)]
    public int countPlayer,numberFoPlayer;                      //Check_number Of Player
    public int id_character,id_player;                          //Check_number Of Player

    // public Button btn_character_id1,btn_character_id2,btn_character_id3,btn_character_id4;
    // public Button btn_select,btn_PlayGlam;
    [Header("Part show UI")] 
    [Tooltip("enter Image show character")]
    public Image ShowCharacter;
    
    [Tooltip("enter button Select character")]
    public Image btn_character_id1,btn_character_id2,btn_character_id3,btn_character_id4;
    [Space(15)]
    bool log_character_id1, log_character_id2, log_character_id3, log_character_id4;  //เช็คการเลือก (true = ยังไม่เลือก) 
    public Text txt_btb,txt_playerSelect;

    // public GameObject popup;

    private void Awake() {
        log_character_id1 = true;
        log_character_id2 = true;
        log_character_id3 = true;
        log_character_id4 = true;

        Check_numberOfPlayer("");  
    }
    void Start(){
        Click_ShowCharacter(0);
    }

   
    public void Check_numberOfPlayer(string _numberPlayer){    //Check_number Of Player
        _numberPlayer = managernumberplayer.numberPlayer;
        switch(_numberPlayer){
            case"1_Player":
                numberFoPlayer = 1;
                break;
            case"2_Player":
                numberFoPlayer = 2;
             break;
            case"3_Player":
                numberFoPlayer = 3;
                break;
            case"4_Player":
                numberFoPlayer = 4;     
                break;
            default:
                break;
        }
    }
    public void Click_ShowCharacter(int _id){            // show character
        id_character = _id;
        ShowCharacter.sprite = set_character[_id];
    }
    private void FixedUpdate() {
        if(countPlayer <  numberFoPlayer){
            txt_btb.text ="เลือก";
            
            switch(countPlayer){
            case 0 : 
                txt_playerSelect.text ="คิว ผู้เล่นที่ 1 เลือกตัวละคร";
                break;
            case 1 :
                txt_playerSelect.text ="คิว ผู้เล่นที่ 2 เลือกตัวละคร";
                break;
            case 2 :
                txt_playerSelect.text ="คิว ผู้เล่นที่ 3 เลือกตัวละคร";
                break;
            case 3 :
                txt_playerSelect.text ="คิว ผู้เล่นที่ 4 เลือกตัวละคร";
                break;
                }   
            }
        else{
            txt_btb.text ="เล่นเกม";
            txt_playerSelect.text ="ไปสนามประลองกัน";
            }

        
    }

     public void Click_SelectCharacter(){         // Select character  && sheck log character

     if( countPlayer <  numberFoPlayer){
          switch (id_character)
            {
                case 0:
                    if(log_character_id1 == true){
                        Set_id.Add (id_character);
                        countPlayer += 1;
                        log_character_id1 = false;    
                        btn_character_id1.color = Color.blue;
                    }
                    else{
                        // Debug.Log("log id="+id_character);
                    }
                break;

                case 1:
                    if(log_character_id2 == true){
                        Set_id.Add (id_character);
                        countPlayer += 1;
                        log_character_id2 = false;
                        btn_character_id2.color = Color.yellow;
                    }
                    else{
                        // Debug.Log("log id="+id_character);
                    }
                break;

                case 2:
                    if(log_character_id3 == true){
                        Set_id.Add (id_character);
                        countPlayer += 1;
                        log_character_id3 = false;
                        btn_character_id3.color = Color.red;
                    }
                    else{
                        // Debug.Log("log id="+id_character);
                    }
                break;

                case 3:
                    if(log_character_id4 == true){
                        Set_id.Add (id_character);
                        countPlayer += 1;
                        log_character_id4 = false;
                        btn_character_id4.color = Color.green;
                    }
                    else{
                        // Debug.Log("log id="+id_character);
                    }
                break;
        
                default: break;
            }    
        }
        else{
            for(int i=0;i < Set_id.Count;i++){
            }

            SceneManager.LoadScene("4Player");    
            // switch(numberFoPlayer){
            //     case 1:
            //         SceneManager.LoadScene("");
            //         break;
            //     case 2:
            //         SceneManager.LoadScene("");
            //         break;
            //     case 3:
            //         SceneManager.LoadScene("");
            //         break;
            //     case 4:
            //         SceneManager.LoadScene("");            
            //         break;

            //     default:
            //     break;
        // }    
        }
     }
    // public void Click_SceneGamePlay(){     // go scene game
    //     SceneManager.LoadScene("");
    // }


}
