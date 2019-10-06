using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player//
public class Player : MonoBehaviour
{
    [Header("manager player")]
        public MakePath framMakePath;
        [Tooltip(" enter ID player ,hp receive data  ")]public int ID_Player ,hp,setHP;
        [Tooltip(" point_n =>new Position ,point_i=>current Position  ")]
        public int point_n ,point_i ;
        private int CountPonit,numberPlayer;   //num
        [Tooltip(" playerRun =>rungame ,live => check live player ")]
        public bool playerRun ,live;
        private Rigidbody2D rb;
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        hp = framMakePath.HP;
        setHP = hp;
        numberPlayer = DataCharacter.Set_id.Count;
        Debug.Log("gameplay = "+numberPlayer);
        
        // live = true;
    }
    public void playGame(int _number)
    { //Debug.Log("playerRun:"+ID_Player);
        if(hp >0)
        {
            CountPonit = _number;
            playerRun = true;
        }
        else{
            playerRun = false;
        }
    }
    // void Update() {}
    private void FixedUpdate() 
    {  
        switch(playerRun)
        {
            case true :
                run();
                break;
        } 
        Check_life();
    }
    public void reduce_life(int _reduce_life)
    {
        hp -= _reduce_life;
        if(hp <= 0)
        {
            Check_life();
        }
    }
    public void add_life( int _addlife )
    {
        hp += _addlife;
        if(hp > setHP)
        {
            hp = setHP;
        }
        Check_life();
    }

    public void Check_life()
    {
        if(hp >0)
        {
            live = true;
        }
        else
        {
            live = false;
        }
    }
    public void run() 
    {
        if(transform.position != framMakePath.Checkbox[point_n].point_Box.position )  // != ให้เข้าหา
        {  //Debug.Log("!= ให้เข้าหา");
            Vector2 poit = Vector2.MoveTowards(transform.position,framMakePath.Checkbox[point_n].point_Box.position,framMakePath.Space*Time.deltaTime);
            rb.MovePosition(poit);
        }
        else
        {   
            point_n = (point_n + 1) % framMakePath.Checkbox.Count;   //check point
            if(CountPonit-1 > 0)
            {         
                CountPonit -= 1 ;              // นับจุดผ่าน
            }
            else
            {   
                playerRun = false;

                if(point_n == 0)
                {
                    point_i = framMakePath.Checkbox.Count-1;
                }
                else
                {
                    point_i = (point_n-1);
                }
                switch(numberPlayer)
                {
                    case 2 :
                        if(point_i == 0 || point_i == 4)
                        {
                            GameColtoler.fromGameColtoler.pointVIP(ID_Player,point_i);
                        }
                        else
                        {
                            testProgram(); 
                        }
                        break;
                    case 3 :
                        if(point_i == 0 || point_i == 4 || point_i == 8)
                        {
                            GameColtoler.fromGameColtoler.pointVIP(ID_Player,point_i);
                        }
                        else
                        {
                            testProgram(); 
                        }
                        break;
                    case 4 :
                        if(point_i == 0 || point_i == 4 || point_i == 8 || point_i == 12)
                        {
                            GameColtoler.fromGameColtoler.pointVIP(ID_Player,point_i);
                        }
                        else
                        {
                        testProgram(); 
                        }
                        break;
                }
                
            }
        }
    }
    public void testProgram()
    {
        Debug.Log("id ="+ID_Player +"point_i="+point_i);
        framMakePath.CheckData_Box(ID_Player,point_i);
    }
}



//******************************************************/
// public void run() {
    //     if(transform.position != framMakePath.point[Box_n].position )  // != ให้เข้าหา
    //         {
    //             // Vector2 poit = Vector2.MoveTowards(transform.position,point[n].position,Space*Time.deltaTime);
    //             // rb.MovePosition(poit);
    //             Vector2 poit = Vector2.MoveTowards(transform.position,framMakePath.point[Box_n].position,framMakePath.Space*Time.deltaTime);
    //             rb.MovePosition(poit);
    //         }
    //     else
    //         {   
    //             Box_n = (Box_n + 1) % framMakePath.point.Length;   
    //             if(num-1 > 0){         // นับจุดผ่าน
    //                 num -= 1 ;
    //                 int i ;
    //                 i =+ 1;
    //                 Debug.Log("i="+i);
    //         }
    //             else
    //             {
    //                 playerRun = false;
    //                 num = numset;
    //             }
    //         }
    //     }