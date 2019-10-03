using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//managrt Player//
public class MakePath : MonoBehaviour
{
    // Start is called before the first frame update
    // public static MakePath  fromMakePath;
    public Transform[] point;
    public float Space;
    public  int n ,num,numset;

    private int box;  //เก็บค่ากลอ่งที่ยืน
    Rigidbody2D rb;
    public bool play;
    
    //  void Awake()
    // {
    //     fromMakePath = this;
    // }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        num = numset;
        // play = true;
    }

    // Update is called once per frame
    // void Update() { }
    public void run(int num){
        numset = num;
        play = true;
    }
    private void FixedUpdate() {

        if(play == true){
            if(transform.position != point[n].position )
            {
                Vector2 poit = Vector2.MoveTowards(transform.position,point[n].position,Space*Time.deltaTime);
                rb.MovePosition(poit);
            }
            else
            {   
                n = (n + 1) % point.Length;
                if(num > 0){
                    num -= 1 ;
                }
                else
                {
                    play = false;
                    num = numset;
                }
            }
        }
        
    }
    // private void Update() {
    //     if(transform.position != point[n].position ){
    //         Vector2 poit = Vector2.MoveTowards(transform.position,point[n].position,Space*Time.deltaTime);
    //         rb.MovePosition(poit);
    //     }
    //     else
    //     {
    //         n = (n + 1) % point.Length;
    //     }
    // }

    public void testP1(int _num){
        Debug.Log("yes p1 ok ="+_num);
    }
    public void testP2(int _num){
        Debug.Log("yes p2 ok ="+_num);
    }
 

     private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("point"))
        {
            if(num < numset-1){
                other.gameObject.SetActive(false);  
                num += 1;
            }
            else
            {
                other.gameObject.SetActive(false);  
                play = false;
                num = 0;
                Debug.Log("end");
            }  
        }
    }
}
