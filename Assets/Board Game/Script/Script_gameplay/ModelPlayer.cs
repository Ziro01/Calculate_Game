using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelPlayer : MonoBehaviour
{
    public MakePath framMakePath;
    [Tooltip(" point_i =>new Position ,point_i=>current Position  ")]
    public int point_n ,point_i ;
    private int CountPonit;   //num
    private Rigidbody2D rb;
     public bool playerRun;

    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        // hp = framMakePath.HP;
        // live = true;
        playerRun = true;
    }
      private void FixedUpdate() 
    {  
        switch(playerRun)
            {
                case true :
                    // Debug.Log("Run:true="+ CountPonit);
                    run();
                    break;
                default :
                    break;
            } 
        // if(hp >0){
        //     live = true;
        // }
        // else{
        //     live = false;
        // }
    }
    public void run() 
    {
        // Debug.Log("Run CountPonit:"+CountPonit);
        if(transform.position != framMakePath.Checkbox[point_n].point_Box.position )  // != ให้เข้าหา
        {  //Debug.Log("!= ให้เข้าหา");

            Vector2 poit = Vector2.MoveTowards(transform.position,framMakePath.Checkbox[point_n].point_Box.position,framMakePath.Space*Time.deltaTime);
            rb.MovePosition(poit);
        }
        else
        {   
            point_n = (point_n + 1) % framMakePath.Checkbox.Count;   //check point
            // if(CountPonit-1 > 0){         
            //     CountPonit -= 1 ;              // นับจุดผ่าน
            //     Debug.Log("Run CountPonit:"+CountPonit);
            // }
            // else
            // {  
                if(point_n == 0){
                    point_i = framMakePath.Checkbox.Count;
                }
                else{
                    point_i = (point_n-1);
                }
                // playerRun = false;
            //     // testProgram();
            // }
        }
    }
}
