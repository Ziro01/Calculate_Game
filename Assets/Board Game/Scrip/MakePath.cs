using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//managrt Player//
public class MakePath : MonoBehaviour
{
    // Start is called before the first frame update
    // public static MakePath  fromMakePath;
    public Transform[] point;
    
    [System.Serializable]
    public class ttt{
        public Transform point;
        public int Owner_p1;
        public int Owner_p2;
        public int Owner_p3;
        public int Owner_p4;
    }
    public List <ttt> list_P = new List <ttt>();
    public float Space;
    // public Vector2 poit;
    public  int n ,num,numset;

    private int box;  //เก็บค่ากลอ่งที่ยืน
    //  Rigidbody2D rb;
    public bool play;
    
    //  void Awake()
    // {
    //     fromMakePath = this;
    // }
    void Start()
    {
        // poit = GetComponent<Vector2>();
        // rb = GetComponent<Rigidbody2D>();
        // num = numset;
        // play = true;
    }

    // Update is called once per frame
    // void Update() { }
    // public void enter(int num){
    //     // Debug.Log("enter="+num);
    //     // numset = num;
    //     play = true;
    // }
    // private void FixedUpdate() {

    //     if(play == true){
    //         // run();
    //     }
        
    // }

    // public void run(int _num){
    //     if(transform.position != point[n].position )  // != ให้เข้าหา
    //         {
    //             // Vector2 poit = Vector2.MoveTowards(transform.position,point[n].position,Space*Time.deltaTime);
    //             // rb.MovePosition(poit);
    //             poit = Vector2.MoveTowards(transform.position,point[n].position,Space*Time.deltaTime);
    //             rb.MovePosition(poit);
    //         }
    //         else
    //         {   
    //             n = (n + 1) % point.Length;   
    //             if(_num > 0){         // นับจุด
    //                 _num -= 1 ;
    //             }
    //             else
    //             {
    //                 play = false;
    //                 // num = numset;
    //             }
    //         }
    // }
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
}
