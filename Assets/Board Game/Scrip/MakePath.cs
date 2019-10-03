using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//managrt Player//
public class MakePath : MonoBehaviour
{
    // Start is called before the first frame update
    // public static MakePath  fromMakePath;
    public Transform[] point;

    public int HP;  //พลังชีวิต

    public int box_i;
    
    [System.Serializable]
    public class DataBox{
        public Transform point_Box;
        public int Owner_p1;
        public int Owner_p2;
        public int Owner_p3;
        public int Owner_p4;
    }
    public List <DataBox> Checkbox = new List <DataBox>();
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
    
     public void test(){
         Debug.Log("connect MakePath");
     }

    public void test_CheckData_Box(int _num){
        box_i = _num;
      
        // int Datap1 = Checkbox[box_i].Owner_p1;
        // int Datap2 = Checkbox[box_i].Owner_p2;
        // int Datap3 = Checkbox[box_i].Owner_p3;
        // int Datap4 = Checkbox[box_i].Owner_p4;

        Debug.Log("Datap1="+Checkbox[box_i].Owner_p1);
        Debug.Log("Datap2="+Checkbox[box_i].Owner_p2);
        Debug.Log("Datap3="+Checkbox[box_i].Owner_p3);
        Debug.Log("Datap4="+Checkbox[box_i].Owner_p4);

    }

    public void CheckData_Box(int id_player){   //เช็คข้อมูลในกล่อง
        switch(id_player){
            case 1:
                if(Checkbox[box_i].Owner_p2 > 0){
                    Checkbox[box_i].Owner_p2 -=1;
                }
                else if (Checkbox[box_i].Owner_p3 > 0){
                    Checkbox[box_i].Owner_p3 -=1;
                } 
                else if (Checkbox[box_i].Owner_p4 > 0){
                    Checkbox[box_i].Owner_p4 -=1;
                }
                else{
                    if(Checkbox[box_i].Owner_p1 < 3) {
                        Checkbox[box_i].Owner_p1 +=1;
                    }
                }
            break;//end

            case 2:
                    if(Checkbox[box_i].Owner_p1 > 0){
                    Checkbox[box_i].Owner_p1 -=1;
                }
                else if (Checkbox[box_i].Owner_p3 > 0){
                    Checkbox[box_i].Owner_p3 -=1;
                } 
                else if (Checkbox[box_i].Owner_p4 > 0){
                    Checkbox[box_i].Owner_p4 -=1; 
                }
                else{
                    if(Checkbox[box_i].Owner_p2 < 3){
                    Checkbox[box_i].Owner_p2 +=1;            
                    }
                }
            break;//end

            case 3:
                if(Checkbox[box_i].Owner_p1 > 0){
                    Checkbox[box_i].Owner_p1 -=1;
                }
                else if (Checkbox[box_i].Owner_p2 > 0){
                    Checkbox[box_i].Owner_p2 -=1;
                } 
                else if (Checkbox[box_i].Owner_p4 > 0){
                    Checkbox[box_i].Owner_p4 -=1;  
                }
                else{
                    if(Checkbox[box_i].Owner_p3 < 3){
                        Checkbox[box_i].Owner_p3 +=1;
                    }
                }
            break;//end

            case 4:
            if(Checkbox[box_i].Owner_p1 > 0){
                    Checkbox[box_i].Owner_p1 -=1;
                }
                else if (Checkbox[box_i].Owner_p2 > 0){
                    Checkbox[box_i].Owner_p2 -=1;
                } 
                else if (Checkbox[box_i].Owner_p3 > 0){
                    Checkbox[box_i].Owner_p3 -=1;
                }
                else{
                    
                    if(Checkbox[box_i].Owner_p4 < 3){
                        Checkbox[box_i].Owner_p4 +=1;
                    }
                }
            break; //end

        }
            // int Datap1 = Checkbox[box_i].Owner_p1;
            // int Datap2 = Checkbox[box_i].Owner_p2;
            // int Datap3 = Checkbox[box_i].Owner_p3;
            // int Datap4 = Checkbox[box_i].Owner_p4;

            // Debug.Log("Datap1="+Datap1);
            // Debug.Log("Datap2="+Datap2);
            // Debug.Log("Datap3="+Datap3);
            // Debug.Log("Datap4="+Datap4);

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
