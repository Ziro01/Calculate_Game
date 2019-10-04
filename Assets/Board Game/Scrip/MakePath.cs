using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//managrt Player//
public class MakePath : MonoBehaviour
{
    // Start is called before the first frame update
    // public static MakePath  fromMakePath;
    // public Transform[] point;

    public int HP;  //พลังชีวิต
    public int box_i;
    
    [System.Serializable]
    public class DataBox
    {
        // public int Box_id;
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
    
    void Awake()
    {
        HP = 5;
    }
    void Start(){}
    public void test()
    {
        Debug.Log("connect MakePath");
    }

    public void test_CheckData_Box(int _num)
    {
        box_i = _num;
        Debug.Log("Datap1="+Checkbox[box_i].Owner_p1);
        Debug.Log("Datap2="+Checkbox[box_i].Owner_p2);
        Debug.Log("Datap3="+Checkbox[box_i].Owner_p3);
        Debug.Log("Datap4="+Checkbox[box_i].Owner_p4);
    }

    public void testProgram(int id_player ,int id_box)
    {
            // framMakePath.test_CheckData_Box(_id);
            // framMakePath.test_CheckData_Box(_id);
        CheckData_Box(id_player,id_box);
    }

    public void CheckData_Box(int id_player ,int id_box)           //เช็คข้อมูลในกล่อง
    {   
        Debug.Log("chect box id ="+id_player+"box = "+id_box);
        switch(id_player){
            case 1:
                if(Checkbox[id_box].Owner_p2 > 0){
                    Checkbox[id_box].Owner_p2 -=1; 
                }
                else if (Checkbox[id_box].Owner_p3 > 0){
                    Checkbox[id_box].Owner_p3 -=1;
                } 
                else if (Checkbox[id_box].Owner_p4 > 0){
                    Checkbox[id_box].Owner_p4 -=1;
                }
                else{
                    if(Checkbox[id_box].Owner_p1 < 3) {
                        Checkbox[id_box].Owner_p1 +=1;
                    }
                }
            break;//end

            case 2:
                if(Checkbox[id_box].Owner_p1 > 0){
                    Checkbox[id_box].Owner_p1 -=1;
                }
                else if (Checkbox[id_box].Owner_p3 > 0){
                    Checkbox[id_box].Owner_p3 -=1;
                } 
                else if (Checkbox[id_box].Owner_p4 > 0){
                    Checkbox[id_box].Owner_p4 -=1; 
                }
                else{
                    if(Checkbox[id_box].Owner_p2 < 3){
                    Checkbox[id_box].Owner_p2 +=1;            
                    }
                }
            break;//end

            case 3:
                if(Checkbox[id_box].Owner_p1 > 0){
                    Checkbox[id_box].Owner_p1 -=1;
                }
                else if (Checkbox[id_box].Owner_p2 > 0){
                    Checkbox[id_box].Owner_p2 -=1;
                } 
                else if (Checkbox[id_box].Owner_p4 > 0){
                    Checkbox[id_box].Owner_p4 -=1;  
                }
                else{
                    if(Checkbox[id_box].Owner_p3 < 3){
                        Checkbox[id_box].Owner_p3 +=1;
                    }
                }
            break;//end

            case 4:
                if(Checkbox[id_box].Owner_p1 > 0){
                    Checkbox[id_box].Owner_p1 -=1;
                }
                else if (Checkbox[id_box].Owner_p2 > 0){
                    Checkbox[id_box].Owner_p2 -=1;
                } 
                else if (Checkbox[id_box].Owner_p3 > 0){
                    Checkbox[id_box].Owner_p3 -=1;
                }
                else{
                    
                    if(Checkbox[id_box].Owner_p4 < 3){
                        Checkbox[id_box].Owner_p4 +=1;
                    }
                }
            break; //end
        }
    }
}
// public class _Dice : RandomDice 
// {    
//     public RandomDice  _random = new RandomDice();


//     public void 


// }
