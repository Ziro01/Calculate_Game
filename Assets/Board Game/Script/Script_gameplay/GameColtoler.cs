using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//managrt gamecontoler//
public class GameColtoler : MonoBehaviour
{    
    DataCharacter _dataCharacter = new DataCharacter();
    public  List<Player>  player = new List<Player>();
    // public RandomDice Dice;
    public static GameColtoler fromGameColtoler;
    [System.Serializable]
    public class set_Skin{                    //skin
        public Sprite skin_Cha;                //ตัว
        public Sprite skin_channel;             //ช่อง
    }
    [Header("manager UI gamepler")]
    [Tooltip("Skin")] public List <set_Skin> series_Skin = new List <set_Skin>();

    [System.Serializable]
    public class set_Charater      //Character
    {          
        public SpriteRenderer Charater;
        public SpriteRenderer channel;
        public Image profile;
    }
    // public Manager_UIgamepler ui_manager;
    [Tooltip("player")]public List <set_Charater> series_Character = new List <set_Charater>();
    [Space(15)]
    public bool play;
    public int playering,playrtNumber,numberRandom;
    public static int Color_P1,Color_P2,Color_P3,Color_P4;
    [Header("manager popup")]
    // public GameObject popup_Bg;
    public Image popup_Bg, character;
    public Text txt_stetusPopup,txt_stetusTurn;

    private void Awake() 
    {
        playrtNumber = DataCharacter.Set_id.Count;
        checkPlayernumber();
    }
    private void Start() 
    {
        fromGameColtoler =this;
        popup_Bg.gameObject.SetActive(false); 
        play =true;

        showStetus();
        InvokeRepeating("check_numberPlayer",2f,2f);
    }
    public  void checkPlayernumber()           //set color player
    {
        switch(playrtNumber){
            case 2 :
                Color_P1 =DataCharacter.Set_id[0];
                Color_P2 =DataCharacter.Set_id[1];

                series_Character[0].Charater.sprite = series_Skin[Color_P1].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[Color_P1].skin_channel;
                series_Character[0].profile.sprite  = series_Skin[Color_P1].skin_Cha; 


                series_Character[1].Charater.sprite = series_Skin[Color_P2].skin_Cha;
                series_Character[1].channel.sprite  = series_Skin[Color_P2].skin_channel;
                series_Character[1].profile.sprite  = series_Skin[Color_P2].skin_Cha; 
                break;
            case 3 :
                Color_P1 =DataCharacter.Set_id[0];
                Color_P2 =DataCharacter.Set_id[1];
                Color_P3 =DataCharacter.Set_id[2];

                series_Character[0].Charater.sprite = series_Skin[Color_P1].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[Color_P1].skin_channel;
                series_Character[0].profile.sprite  = series_Skin[Color_P1].skin_Cha; 
                
                series_Character[1].Charater.sprite = series_Skin[Color_P2].skin_Cha;
                series_Character[1].channel.sprite  = series_Skin[Color_P2].skin_channel;
                series_Character[1].profile.sprite = series_Skin[Color_P2].skin_Cha; 

                series_Character[2].Charater.sprite = series_Skin[Color_P3].skin_Cha;
                series_Character[2].channel.sprite  = series_Skin[Color_P3].skin_channel;
                series_Character[2].profile.sprite  = series_Skin[Color_P3].skin_Cha; 
                break;
            case 4 :
                Color_P1 =DataCharacter.Set_id[0];
                Color_P2 =DataCharacter.Set_id[1];
                Color_P3 =DataCharacter.Set_id[2];
                Color_P4 =DataCharacter.Set_id[3];
                
                series_Character[0].Charater.sprite = series_Skin[Color_P1].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[Color_P1].skin_channel;
                series_Character[0].profile.sprite = series_Skin[Color_P1].skin_Cha;

        
                series_Character[1].Charater.sprite = series_Skin[Color_P2].skin_Cha;
                series_Character[1].channel.sprite  = series_Skin[Color_P2].skin_channel;
                series_Character[1].profile.sprite  = series_Skin[Color_P2].skin_Cha;

 
                series_Character[2].Charater.sprite = series_Skin[Color_P3].skin_Cha;
                series_Character[2].channel.sprite  = series_Skin[Color_P3].skin_channel;
                series_Character[2].profile.sprite  = series_Skin[Color_P3].skin_Cha;

            
                series_Character[3].Charater.sprite = series_Skin[Color_P4].skin_Cha;
                series_Character[3].channel.sprite  = series_Skin[Color_P4].skin_channel;
                series_Character[3].profile.sprite  = series_Skin[Color_P4].skin_Cha; 
                break;
        }
    }
    private void FixedUpdate() {
        if(player[playering].live == false){
            run_turn();
        }
    }
    public void playGame(int _numberRandom)
    { 
        switch (player[playering].live)       
        {                                                   //Check live player
            case true:
                player[playering].playGame(_numberRandom);           //enter number fo random
                run_turn();
                break;
            case false :
                run_turn();
                break;
        }
    }
    public void run_turn()
    {
        playering = (playering + 1) % player.Count;
        showStetus();
    }
    void showStetus()
    {
        txt_stetusTurn.text = "คิว ผู้เล่น :"+ (playering+1);
    }
    public void check_numberPlayer()                      //check_numberPlayer
    {
        int check_Player = player.Count ;
        for(int i=0; i < player.Count;i++)
        {
            if(player[i].live == false)
            {
                check_Player -= 1;
                MakePath.from_MakePath.delete_Token(i+1);
            
                if(check_Player <= 1)
                {
                  Invoke("setting_popup",3f);
                }
            }
        }
    }
    void setting_popup(){
        for(int i=0; i < player.Count;i++)
        {
            if(player[i].live == true)
            {
                if(i == player.Count){
                    i=0;
                    character.sprite = series_Skin[i].skin_Cha;
                    popup_Bg.sprite = series_Skin[i].skin_channel;
                }
                else
                {
                    character.sprite = series_Skin[i+1].skin_Cha;
                    popup_Bg.sprite = series_Skin[i+1].skin_channel;
                   
                } 
                txt_stetusPopup.text = "ผู้ชนะ";
                popup_Bg.gameObject.SetActive(true);
                
            }
        }    
    }
    public  void  Reduce_life(int _id,int _damage)            //-hp
    {    
        switch (_id){
            case 1:
                player[0].reduce_life(_damage);
                break; 
            case 2:
                player[1].reduce_life(_damage);
                break; 
            case 3:
                player[2].reduce_life(_damage);
                break; 
            case 4:
                player[3].reduce_life(_damage);
                break; 
        }
    }
    public  void  Add_life(int _id,int _add_life)                    //+hp
    {         
        switch (_id)
        {
            case 1:
                player[0].add_life(_add_life);
                break; 
            case 2:
                player[1].add_life(_add_life);
                break; 
            case 3:
                player[2].add_life(_add_life);
                break; 
            case 4:
                player[3].add_life(_add_life);
                break; 
        }
    }
    public void pointVIP(int _id,int _point)    //check pointVIP
    {
        switch(_id)
        {
            case 1 :
                switch(_point)
                {
                    case 0 :
                        Add_life(1,3);
                        break;
                    case 4 :
                        Add_life(1,1);
                        break;
                    case 8 :
                        Add_life(1,1);
                        break;
                    case 12 :
                        Add_life(1,1);
                        break;
                } 
                break;
            case 2 :
                switch(_point)
                {
                    case 0 :
                        Add_life(2,1);
                        break;
                    case 4 :
                        Add_life(2,3);
                        break;
                    case 8 :
                        Add_life(2,1);
                        break;
                    case 12 :
                        Add_life(2,1);
                        break;
                } 
                break;
            case 3 :
                switch(_point)
                {
                    case 0 :
                        Add_life(3,1);
                        break;
                    case 4 :
                        Add_life(3,1);
                        break;
                    case 8 :
                        Add_life(3,3);
                        break;
                    case 12 :
                        Add_life(3,1);
                        break;
                    } 
                    break;
            case 4 :
                switch(_point)
                {
                    case 0 :
                        Add_life(4,1);
                        break;
                    case 4 :
                        Add_life(4,1);
                        break;
                    case 8 :
                        Add_life(4,1);
                        break;
                    case 12 :
                        Add_life(4,3);
                        break;
                }  
                break;
        }
    }
    public void clickTo_menu(){
        SceneManager.LoadScene("Choose_character");
    }
}

public class DataCharacter : managerCharacter{ 
    public managerCharacter _dataCharacter = new managerCharacter();

    public class setting_Ponit : MakePath{
        
    }
}
