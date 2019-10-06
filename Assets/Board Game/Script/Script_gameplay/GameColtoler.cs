using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//managrt gamecontoler//
public class GameColtoler : MonoBehaviour
{    
    DataCharacter _dataCharacter = new DataCharacter();
    public  List<Player>  player = new List<Player>();
    public static GameColtoler fromGameColtoler;
    [System.Serializable]
    public class set_Skin{                    //skin
        public Sprite skin_Cha;                //ตัว
        public Sprite skin_channel;             //ช่อง
    }
    [Header("manager UIgamepler")]
    [Tooltip("Skin")] public List <set_Skin> series_Skin = new List <set_Skin>();

    [System.Serializable]
    public class set_Charater      //Character
    {          
        public SpriteRenderer Charater;
        public SpriteRenderer channel;
    }
    // public Manager_UIgamepler ui_manager;
    [Tooltip("player")]public List <set_Charater> series_Character = new List <set_Charater>();
    [Space(15)]
    public int playering,playrtNumber;
    public static int Color_P1,Color_P2,Color_P3,Color_P4;
    private void Awake() 
    {
        playrtNumber = DataCharacter.Set_id.Count;
        checkPlayernumber();
    }
    private void Start() 
    {
        fromGameColtoler =this;
        // Debug.Log("GameColtoler = "+ DataCharacter.Set_id.Count);
    }
    public  void checkPlayernumber()
    {
        switch(playrtNumber){
            case 1 :
                Color_P1 =DataCharacter.Set_id[0];
                series_Character[0].Charater.sprite = series_Skin[Color_P1].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[Color_P1].skin_channel;

                break;
            case 2 :
                Color_P1 =DataCharacter.Set_id[0];
                Color_P2 =DataCharacter.Set_id[1];
                series_Character[0].Charater.sprite = series_Skin[Color_P1].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[Color_P1].skin_channel;

                series_Character[1].Charater.sprite = series_Skin[Color_P2].skin_Cha;
                series_Character[1].channel.sprite  = series_Skin[Color_P2].skin_channel;
                break;
            case 3 :
                Color_P1 =DataCharacter.Set_id[0];
                Color_P2 =DataCharacter.Set_id[1];
                Color_P3 =DataCharacter.Set_id[2];

                series_Character[0].Charater.sprite = series_Skin[Color_P1].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[Color_P1].skin_channel;
                
                series_Character[1].Charater.sprite = series_Skin[Color_P2].skin_Cha;
                series_Character[1].channel.sprite  = series_Skin[Color_P2].skin_channel;

                series_Character[2].Charater.sprite = series_Skin[Color_P3].skin_Cha;
                series_Character[2].channel.sprite  = series_Skin[Color_P3].skin_channel;
                break;
            case 4 :
                Color_P1 =DataCharacter.Set_id[0];
                Color_P2 =DataCharacter.Set_id[1];
                Color_P3 =DataCharacter.Set_id[2];
                Color_P4 =DataCharacter.Set_id[3];

                series_Character[0].Charater.sprite = series_Skin[Color_P1].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[Color_P1].skin_channel;
                
                series_Character[1].Charater.sprite = series_Skin[Color_P2].skin_Cha;
                series_Character[1].channel.sprite  = series_Skin[Color_P2].skin_channel;

                series_Character[2].Charater.sprite = series_Skin[Color_P3].skin_Cha;
                series_Character[2].channel.sprite  = series_Skin[Color_P3].skin_channel;

                series_Character[3].Charater.sprite = series_Skin[Color_P4].skin_Cha;
                series_Character[3].channel.sprite  = series_Skin[Color_P4].skin_channel;
                
            break;
        }
    }
    public void playGame()
    {
        // Debug.Log("player:"+playering +"live:"+player[playering].live); 
        switch (player[playering].live)       
        {                                                   //Check live player
            case true:
                player[playering].playGame(4);
                run_turn();
                break;
            case false :
                run_turn();
                break;
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
                player[0].reduce_life(_add_life);
                break; 
            case 2:
                player[1].reduce_life(_add_life);
                break; 
            case 3:
                player[2].reduce_life(_add_life);
                break; 
            case 4:
                player[3].reduce_life(_add_life);
                break; 
        }
    }
    public void run_turn()
    {
        playering = (playering + 1) % player.Count;
    }  

    public void pointVIP(int _id,int _point)
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

}
public class _Dice : RandomDice {    
    public RandomDice  _random = new RandomDice(); 
}
public class DataCharacter : managerCharacter{ 
    public managerCharacter _dataCharacter = new managerCharacter();
}
