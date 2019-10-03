using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Player//
public class Player : MonoBehaviour
{
    // Start is called before the first frame updat
    // MakePath Players = new MakePath();

    public MakePath framMakePath;
    public int Box_n ,num =5,numset;

    public bool Player_turn,playerRun;

    Rigidbody2D rb;
    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
        numset=num;

    }

    public void playGame(){
        playerRun = true;
    }


    // Update is called once per frame
    // void Update() {}

    private void FixedUpdate() {
       
        switch(playerRun)
            {
                case true  :
                    run();
                break;

                default :
                break;
            } 
    }

    public void run() {
        if(transform.position != framMakePath.point[Box_n].position )  // != ให้เข้าหา
            {
                // Vector2 poit = Vector2.MoveTowards(transform.position,point[n].position,Space*Time.deltaTime);
                // rb.MovePosition(poit);
                Vector2 poit = Vector2.MoveTowards(transform.position,framMakePath.point[Box_n].position,framMakePath.Space*Time.deltaTime);
                rb.MovePosition(poit);
            }
        else
            {   
                Box_n = (Box_n + 1) % framMakePath.point.Length;   
                if(num-1 > 0){         // นับจุดผ่าน
                    num -= 1 ;
                    int i ;
                    i =+ 1;
                    Debug.Log("i="+i);
            }
                else
                {
                    playerRun = false;
                    num = numset;
                }
            }
        }
}
