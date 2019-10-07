using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//managrt Player//
public class MakePath : MonoBehaviour
{
    public static  MakePath from_MakePath;
    public int HP;  //พลังชีวิต
    public int box_i;
    
    [System.Serializable]
    public class DataBox
    {
        // public int Box_id;
        [Tooltip("position")]public Transform point_Box;
        [Tooltip("show token")]public SpriteRenderer token;
        public int Owner_p1;
        public int Owner_p2;
        public int Owner_p3;
        public int Owner_p4;
    }
    [Tooltip("data point")]public List <DataBox> Checkbox = new List <DataBox>();

    [System.Serializable]
    public class tokenBox
    {
        [Tooltip("enter Sprite")]public Sprite token_0;
        [Tooltip("enter Sprite")]public Sprite token_1;
        [Tooltip("enter Sprite")]public Sprite token_2;
        [Tooltip("enter Sprite")]public Sprite token_3;
    }
    [Tooltip("data token")]public List <tokenBox> Check_tokenBox = new List <tokenBox>();
    [Tooltip("enter speed")]public float Space;
    [Tooltip("Wait to receive")]public int Color_P1,Color_P2,Color_P3,Color_P4;   //
    
    void Awake()
    {
        HP = 3;
        Space = 6f;
    }
    private void Start()
    {
        from_MakePath = this;
        Color_P1 = GameColtoler.Color_P1;
        Color_P2 = GameColtoler.Color_P2;
        Color_P3 = GameColtoler.Color_P3;
        Color_P4 = GameColtoler.Color_P4;

        InvokeRepeating("check_toket_p1",1f,1f);
        InvokeRepeating("check_toket_p2",1f,1f);
        InvokeRepeating("check_toket_p3",1f,1f);
        InvokeRepeating("check_toket_p4",1f,1f);
    }
    public void CheckData_Box(int _id_player ,int _id_point)           //เช็คข้อมูลในกล่อง ()
    {   
        switch(_id_player)
        {
            case 1:
                if(Checkbox[_id_point].Owner_p2 > 0)
                {
                    GameColtoler.fromGameColtoler.Reduce_life(1,Checkbox[_id_point].Owner_p2);
                    Checkbox[_id_point].Owner_p2 -=1;
                    setAdd_Token("Owner_p2", _id_point, Color_P2);                   
                    
                    if(Checkbox[_id_point].Owner_p2 <= 0)
                    {
                        Add_Token(1,_id_point);
                    }
                }
                else if (Checkbox[_id_point].Owner_p3 > 0)
                {
                    GameColtoler.fromGameColtoler.Reduce_life(1,Checkbox[_id_point].Owner_p3);
                    Checkbox[_id_point].Owner_p3 -=1;
                    setAdd_Token("Owner_p3", _id_point, Color_P3);                    

                    if(Checkbox[_id_point].Owner_p3 <= 0)
                    {
                        Add_Token(1,_id_point);
                    }
                } 
                else if (Checkbox[_id_point].Owner_p4 > 0)
                {
                    GameColtoler.fromGameColtoler.Reduce_life(1,Checkbox[_id_point].Owner_p4);
                    Checkbox[_id_point].Owner_p4 -=1;
                    setAdd_Token("Owner_p4", _id_point, Color_P4);                   

                    if(Checkbox[_id_point].Owner_p4 <= 0)
                    {
                        Add_Token(1,_id_point);
                    }
                }
                else
                {
                    if(Checkbox[_id_point].Owner_p1 < 3) 
                    {
                        Add_Token(1,_id_point);
                    }
                }
                    break;
            case 2:
                if(Checkbox[_id_point].Owner_p1 > 0)
                {
                    GameColtoler.fromGameColtoler.Reduce_life(2,Checkbox[_id_point].Owner_p1);
                    Checkbox[_id_point].Owner_p1 -=1;
                    setAdd_Token("Owner_p1", _id_point, Color_P1);

                    if(Checkbox[_id_point].Owner_p1 <= 0)
                    {
                        Add_Token(2,_id_point);
                    }
                }
                else if (Checkbox[_id_point].Owner_p3 > 0)
                {
                    GameColtoler.fromGameColtoler.Reduce_life(2,Checkbox[_id_point].Owner_p3);
                    Checkbox[_id_point].Owner_p3 -=1;
                    setAdd_Token("Owner_p3",_id_point, Color_P3);
                    

                    if(Checkbox[_id_point].Owner_p3 <= 0)
                    {
                        Add_Token(2,_id_point);
                    }
                } 
                else if (Checkbox[_id_point].Owner_p4 > 0)
                { 
                    GameColtoler.fromGameColtoler.Reduce_life(2,Checkbox[_id_point].Owner_p4);
                    Checkbox[_id_point].Owner_p4 -=1; 
                    setAdd_Token("Owner_p4",_id_point, Color_P4);

                    if(Checkbox[_id_point].Owner_p4 <= 0)
                    {
                        Add_Token(2,_id_point);
                    }
                }
                else{
                    if(Checkbox[_id_point].Owner_p2 < 3)
                    {
                        Add_Token(2,_id_point);    
                    }
                }
                break;
            case 3:
                if(Checkbox[_id_point].Owner_p1 > 0)
                {
                    GameColtoler.fromGameColtoler.Reduce_life(3,Checkbox[_id_point].Owner_p1);
                    Checkbox[_id_point].Owner_p1 -=1;
                    setAdd_Token("Owner_p1", _id_point, Color_P1);
                    
                    if(Checkbox[_id_point].Owner_p1 <= 0)
                    {
                        Add_Token(3,_id_point);
                    }
                }
                else if (Checkbox[_id_point].Owner_p2 > 0)
                {
                    GameColtoler.fromGameColtoler.Reduce_life(3,Checkbox[_id_point].Owner_p2);
                    Checkbox[_id_point].Owner_p2 -=1;
                    setAdd_Token("Owner_p2", _id_point, Color_P2);
                    

                    if(Checkbox[_id_point].Owner_p2 <= 0)
                    {
                        Add_Token(3,_id_point);
                    }
                } 
                else if (Checkbox[_id_point].Owner_p4 > 0)
                {
                    GameColtoler.fromGameColtoler.Reduce_life(3,Checkbox[_id_point].Owner_p4);
                    Checkbox[_id_point].Owner_p4 -=1;  
                    setAdd_Token("Owner_p4", _id_point, Color_P4);

                    if(Checkbox[_id_point].Owner_p4 <= 0)
                    {
                        Add_Token(3,_id_point);
                    }
                }
                else
                {
                    if(Checkbox[_id_point].Owner_p3 < 3)
                    {
                        Checkbox[_id_point].Owner_p3 +=1;
                        setAdd_Token("Owner_p3",_id_point,  Color_P3);
                    }
                }
                break;
            case 4:
                if(Checkbox[_id_point].Owner_p1 > 0)
                {
                    GameColtoler.fromGameColtoler.Reduce_life(4,Checkbox[_id_point].Owner_p1);
                    Checkbox[_id_point].Owner_p1 -=1;
                    setAdd_Token("Owner_p1",_id_point,  Color_P1);
                    

                    if(Checkbox[_id_point].Owner_p1 <= 0)
                    {
                        Add_Token(4,_id_point);
                    }
                }
                else if (Checkbox[_id_point].Owner_p2 > 0)
                {
                    GameColtoler.fromGameColtoler.Reduce_life(4,Checkbox[_id_point].Owner_p2);
                    Checkbox[_id_point].Owner_p2 -=1;
                    setAdd_Token("Owner_p2",_id_point,  Color_P2);                 

                    if(Checkbox[_id_point].Owner_p2 <= 0)
                    {
                        Add_Token(4,_id_point);
                    }
                } 
                else if (Checkbox[_id_point].Owner_p3 > 0)
                { 
                    GameColtoler.fromGameColtoler.Reduce_life(4,Checkbox[_id_point].Owner_p3);
                    Checkbox[_id_point].Owner_p3 -=1;
                    setAdd_Token("Owner_p3",_id_point,  Color_P3);                   

                    if(Checkbox[_id_point].Owner_p3 <= 0)
                    {
                        Add_Token(4,_id_point);
                    }
                }
                else
                {
                    if(Checkbox[_id_point].Owner_p4 < 3)
                    {
                        Add_Token(4,_id_point);
                    }
                }
                break;
        } 
    }
    public void Add_Token(int _id,int _point){   //_point == CheckData_Box._id_point
        switch(_id)
        {
            case 1:    
                Checkbox[_point].Owner_p1 +=1;
                setAdd_Token("Owner_p1",_point,  Color_P1);
                break;
            case 2:  
                Checkbox[_point].Owner_p2 +=1;
                setAdd_Token("Owner_p2",_point,  Color_P2);
                break;
            case 3:  
                Checkbox[_point].Owner_p3 +=1;
                setAdd_Token("Owner_p3",_point,  Color_P3);
                break;
            case 4:     
                Checkbox[_point].Owner_p4 +=1;
                setAdd_Token("Owner_p4",_point,  Color_P4);
                break;
        }
    }
    public void delete_Token(int _id){   //_point == CheckData_Box._id_point
        switch(_id)
        {
            case 1:
                for(int i = 0; i < Checkbox.Count; i++)
                {
                  Checkbox[i].Owner_p1 = 0;
                  setAdd_Token("Owner_p1",i,  Color_P1);
                }
                break;
            case 2:
                for(int i=0; i < Checkbox.Count; i++)
                {
                  Checkbox[i].Owner_p2 = 0;
                  setAdd_Token("Owner_p2",i,  Color_P2);
                }
                break;
            case 3:
                for(int i=0; i < Checkbox.Count; i++)
                {
                  Checkbox[i].Owner_p3 = 0;
                  setAdd_Token("Owner_p3",i,  Color_P3);
                }
                break;
            case 4:
                for(int i=0; i < Checkbox.Count; i++)
                {
                  Checkbox[i].Owner_p4 = 0;
                  setAdd_Token("Owner_p4",i,  Color_P4);
                }
                break;
        }
    }
    public void check_toket_p1()          //check_toket_player 1
    {
        for(int i=0; i < Checkbox.Count; i++)
        {  
          
                if(Checkbox[i].Owner_p1 == 1)
                {                
                    Checkbox[i].token.sprite =  Check_tokenBox[Color_P1].token_1;
                }
                if(Checkbox[i].Owner_p1 == 2)
                {                
                    Checkbox[i].token.sprite =  Check_tokenBox[Color_P1].token_2; 
                }
                if(Checkbox[i].Owner_p1 == 3)
                {
                    Checkbox[i].token.sprite =  Check_tokenBox[Color_P1].token_3;
                }
                else
                {
                    if(Checkbox[i].Owner_p1 == 0 && Checkbox[i].Owner_p1 == 0  &&  Checkbox[i].Owner_p1 == 0 &&  Checkbox[i].Owner_p1 == 0)
                    {
                        Checkbox[i].token.sprite =  Check_tokenBox[Color_P1].token_0;
                    }
                }
            }
    }
     public void check_toket_p2()               //check_toket_player 2
    {
        for(int i=0; i < Checkbox.Count; i++)
        {
            if(Checkbox[i].Owner_p2 == 1)
            {                
                Checkbox[i].token.sprite =  Check_tokenBox[Color_P2].token_1;
            }
            if(Checkbox[i].Owner_p2 == 2)
            {                
                Checkbox[i].token.sprite =  Check_tokenBox[Color_P2].token_2; 
            }
            if(Checkbox[i].Owner_p2 == 3)
            {
                Checkbox[i].token.sprite =  Check_tokenBox[Color_P2].token_3;
            }
            else{}
        }
    }
     public void check_toket_p3()                 //check_toket_player 3
    {   
        for(int i=0; i < Checkbox.Count; i++)
        {
             if(Checkbox[i].Owner_p3 == 1)
            {                
                Checkbox[i].token.sprite =  Check_tokenBox[Color_P3].token_1;
            }
            if(Checkbox[i].Owner_p3 == 2)
            {                
                Checkbox[i].token.sprite =  Check_tokenBox[Color_P3].token_2;  
            }
            if(Checkbox[i].Owner_p3 == 3)
            {
                Checkbox[i].token.sprite =  Check_tokenBox[Color_P3].token_3; 
            }
            else{}
        }
    }
     public void check_toket_p4()                 //check_toket_player 2
    {
        for(int i=0; i < Checkbox.Count; i++)
        {
            if(Checkbox[i].Owner_p4 == 1)
            {                
                Checkbox[i].token.sprite =  Check_tokenBox[Color_P4].token_1;
            }
            if(Checkbox[i].Owner_p4 == 2)
            {                
                Checkbox[i].token.sprite =  Check_tokenBox[Color_P4].token_2; 
            }
            if(Checkbox[i].Owner_p4 == 3)
            {
                Checkbox[i].token.sprite =  Check_tokenBox[Color_P4].token_3;
            }
            else{}
        }
    }
    public void setAdd_Token(string _ownerPoint,int _idPoint,int _idTokenColor){    //add togen 
        switch(_ownerPoint)
        {
            case "Owner_p1":
                switch(Checkbox[_idPoint].Owner_p1)
                {  
                    case 1 :                                                                       
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_1;  
                        break;
                    case 2 :      
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_2;               
                        break;
                    case 3 :   
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_3;  
                        break;
                    default:    
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_0;
                        break;
                    }
                break;
            case "Owner_p2":
                switch(Checkbox[_idPoint].Owner_p2)
                {
                    case 1 :                                                                            
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_1;  
                        break;
                    case 2 :
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_2;               
                        break;
                    case 3 :
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_3;  
                        break;
                    default:
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_0;
                        break;
                    }
                break;

            case "Owner_p3":
                switch(Checkbox[_idPoint].Owner_p3)
                {
                    case 1 :                                                                            
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_1;  
                        break;
                    case 2 :
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_2;               
                        break;
                    case 3 :
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_3;  
                        break;
                    default:
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_0;
                        break;
                }
                break;

            case "Owner_p4":
                switch(Checkbox[_idPoint].Owner_p4)
                {
                    case 1 :                                                                            
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_1; 
                        break;
                    case 2 :
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_2;               
                        break;
                    case 3 :
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_3;  
                        break;
                    default:
                        Checkbox[_idPoint].token.sprite =  Check_tokenBox[_idTokenColor].token_0;
                        break;
                }
                break;
        }
    }
}
