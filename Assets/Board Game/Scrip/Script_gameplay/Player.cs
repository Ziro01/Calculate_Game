using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player//
public class Player : MonoBehaviour
{
        public MakePath framMakePath;
        [Tooltip(" ID player ")]public int ID_Player ,hp ;
        public int Box_n ,Box_i ;
        private int num;
        public bool playerRun ,live;
        private Rigidbody2D rb;
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        hp = framMakePath.HP;
    }
    public void playGame()
    {
        if(hp >0){
            playerRun = true;
        }
        else{
            Debug.Log("playerID = "+ID_Player +"lost");
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

                default :
                break;
            } 


        if(hp >0){
            live = true;
        }
        else{
            live = false;
        }
    }
    public void run() 
    {
        if(transform.position != framMakePath.Checkbox[Box_n].point_Box.position )  // != ให้เข้าหา
        {
            Vector2 poit = Vector2.MoveTowards(transform.position,framMakePath.Checkbox[Box_n].point_Box.position,framMakePath.Space*Time.deltaTime);
            rb.MovePosition(poit);
        }
        else
        {   
            Box_n = (Box_n + 1) % framMakePath.Checkbox.Count;   
            if(num-1 > 0){         
                num -= 1 ;              // นับจุดผ่าน
            }
            else
            {  
                if(Box_n == 0){
                    Box_i = framMakePath.Checkbox.Count;
                }
                else{
                    Box_i = (Box_n-1);
                }
                playerRun = false;
                testProgram();
            }
        }
    }
    public void testProgram()
    {
        // framMakePath.test_CheckData_Box(_id);
        // framMakePath.test_CheckData_Box(_id);
        framMakePath.CheckData_Box(ID_Player,Box_i);
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