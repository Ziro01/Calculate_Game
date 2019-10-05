using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = .2f ;
    Transform target;
    string tagname = "point";
    // Start is called before the first frame update

    public bool play;
    void Start()
    {
        play = false;
        sect_point();
    }

    // Update is called once per frame
    // void Update(){}
    private void FixedUpdate() {
        if(play == true){

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed*Time.deltaTime);
        }
        
    }

     public void sect_point(){
            
            if(GameObject.FindGameObjectWithTag(tagname) != null ){
                target = GameObject.FindGameObjectWithTag(tagname).GetComponent<Transform>(); //เช็ค Objectที่ติดแท๊ก  
                    
                    // if(Vector2.Distance(transform.position,target.position) < 1){ 
                        play = true; 
                    // }
            }
            else
            {
                Debug.Log(" no target ");
                play = false;
            }
            // play = true;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag(tagname)){
            other.gameObject.SetActive(false);
            Debug.Log("ชน"+other.gameObject.name);
            sect_point();
        }
    }

    void count(){
        
    }
}
