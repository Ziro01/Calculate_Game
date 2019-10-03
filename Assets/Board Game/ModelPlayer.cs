using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelPlayer : MonoBehaviour
{
    public bool play;

     Transform  targer;
     string tagname = "point";

    public int count =  0, setcout;
     float speed = 0.05f;

    // public Board boardG ;
    // Start is called before the first frame update
    void Start()
    {       
        sect_point();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(play == true){
           transform.position = Vector2.MoveTowards(transform.position,targer.position,speed*Time.deltaTime);
       
        }
    }
    
    public void sect_point(){
            targer = GameObject.FindGameObjectWithTag(tagname).GetComponent<Transform>(); //เช็ค Objectที่ติดแท๊ก player 
            play = true;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("point")){
            other.gameObject.SetActive(false);
            if(count < setcout-1){
                count += 1;
                sect_point();
            }
            else if(count == setcout){
                Debug.Log("_Board");
            }
            else{
                Debug.Log("end");
            } 
        }
    }
}
