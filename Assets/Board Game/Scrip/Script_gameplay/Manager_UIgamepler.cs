using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI
public class Manager_UIgamepler : MonoBehaviour
{
    // public List<Sprite> Character = new List<Sprite>();
    // public List <GameObject> p1 = new List<GameObject>();  

     [System.Serializable]
        public class set_Skin{          //skin
        public Sprite skin_Cha;   //ตัว
        public Sprite skin_channel;   //ช่อง
    }
    [Tooltip("Skin")] public List <set_Skin> series_Skin = new List <set_Skin>();


    [System.Serializable]
        public class set_Charater{          //Character
        public SpriteRenderer Charater;
        public SpriteRenderer channel;
    }
    [Tooltip("player")]public List <set_Charater> series_Character = new List <set_Charater>();

    public int player01,player02,player03,player04;

    // public int setcha;

    // public SpriteRenderer cha1;
    
    void Start()
    {
        // cha1.sprite = Character[setcha];
        // cha1.material.color = Color.black;  //material เปลียนสี
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void settingUI(){
        switch(player01){        //player 1
            case 0 :
                series_Character[0].Charater.sprite = series_Skin[0].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[0].skin_channel;

            break;

            case 1 :
                series_Character[0].Charater.sprite = series_Skin[1].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[1].skin_channel;
            
            break;
            case 2 :
                series_Character[0].Charater.sprite = series_Skin[2].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[2].skin_channel;
            
            break;

            case 4 :
                series_Character[0].Charater.sprite = series_Skin[3].skin_Cha;
                series_Character[0].channel.sprite  = series_Skin[3].skin_channel;
            
            break;
        }

        switch(player02){        //player 2
            case 0 :
                series_Character[1].Charater.sprite = series_Skin[0].skin_Cha;
                series_Character[1].channel.sprite  = series_Skin[0].skin_channel;

            break;

            case 1 :
                series_Character[1].Charater.sprite = series_Skin[1].skin_Cha;
                series_Character[1].channel.sprite  = series_Skin[1].skin_channel;
            
            break;
            case 2 :
                series_Character[1].Charater.sprite = series_Skin[2].skin_Cha;
                series_Character[1].channel.sprite  = series_Skin[2].skin_channel;
            
            break;

            case 4 :
                series_Character[1].Charater.sprite = series_Skin[3].skin_Cha;
                series_Character[1].channel.sprite  = series_Skin[3].skin_channel;
            
            break;
        }
         switch(player03){    //player 3
            case 0 :
                series_Character[2].Charater.sprite = series_Skin[0].skin_Cha;
                series_Character[2].channel.sprite  = series_Skin[0].skin_channel;

            break;

            case 1 :
                series_Character[2].Charater.sprite = series_Skin[1].skin_Cha;
                series_Character[2].channel.sprite  = series_Skin[1].skin_channel;
            
            break;
            case 2 :
                series_Character[2].Charater.sprite = series_Skin[2].skin_Cha;
                series_Character[2].channel.sprite  = series_Skin[2].skin_channel;
            
            break;

            case 4 :
                series_Character[2].Charater.sprite = series_Skin[3].skin_Cha;
                series_Character[2].channel.sprite  = series_Skin[3].skin_channel;
            
            break;
        }
        switch(player04){    //player 4
            case 0 :
                series_Character[3].Charater.sprite = series_Skin[0].skin_Cha;
                series_Character[3].channel.sprite  = series_Skin[0].skin_channel;

            break;

            case 1 :
                series_Character[3].Charater.sprite = series_Skin[1].skin_Cha;
                series_Character[3].channel.sprite  = series_Skin[1].skin_channel;
            
            break;
            case 2 :
                series_Character[3].Charater.sprite = series_Skin[2].skin_Cha;
                series_Character[3].channel.sprite  = series_Skin[2].skin_channel;
            
            break;

            case 4 :
                series_Character[3].Charater.sprite = series_Skin[3].skin_Cha;
                series_Character[3].channel.sprite  = series_Skin[3].skin_channel;
            
            break;
        }

    }


}
