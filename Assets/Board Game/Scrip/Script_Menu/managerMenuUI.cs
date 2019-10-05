using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class managerMenuUI : MonoBehaviour
{
    [Header("Part Data")]
    public List <Sprite> set_character = new List <Sprite>();
    public List <int> Set_id = new List <int>();
    public int id_character,id_player;
    public Button btn_character_id1,btn_character_id2,btn_character_id3,btn_character_id4;
    public Button btn_select,btn_PlayGlam;
    bool log_character_id1, log_character_id12, log_character_id13, log_character_id14;  //เช็คการเลือก (true = ยังไม่เลือก) 

    [Header("Part show popup")] 
    public Image ShowCharacter;

    public GameObject popup;

    private void Awake() {
        log_character_id1 = true;
        log_character_id1 = true;
        log_character_id1 = true;
        log_character_id1 = true;
        
    }
    void Start(){
        Click_ShowCharacter(0);

        btn_character_id1.onClick.AddListener(()=>{ 

        });
        btn_character_id2.onClick.AddListener(()=>{ 

        });
        btn_character_id3.onClick.AddListener(()=>{

        });
        btn_character_id4.onClick.AddListener(()=>{

        });

        btn_select.onClick.AddListener(()=>{   //id cha
            switch (id_character)
            {
                case 0:
                    if(log_character_id1 == false){
                    }
                    else{

                    }
                break;

                case 1:
                    if(log_character_id1 == false){
                    }
                    else{

                    }
                break;

                case 2:
                    if(log_character_id1 == false){
                    }
                    else{

                    }
                break;
                case 3:
                    if(log_character_id1 == false){
                    }
                    else{

                    }
                break;
                
                default:
                break;
            }
        });
    }

    void Update(){}
    public void Click_ShowCharacter(int _id){            // show character
        id_character = _id;
        ShowCharacter.sprite = set_character[_id];
    }
     public void Click_SelectCharacter(){         // Select character
       
        Set_id[id_player] = id_character;
    }

    public void Check_Data(){
    }



    
    public void Click_SceneGamePlay(){     // go scene game
        SceneManager.LoadScene("");
    }


}
