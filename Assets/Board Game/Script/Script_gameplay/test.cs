using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{


    [System.Serializable]
    public class DataBox
    {
        public SpriteRenderer Owner_p1;
        // public SpriteRenderer Owner_p2;
        // public SpriteRenderer Owner_p3;
        public int num_p1;
        public int num_p2;
        public int num_p3;
        public int num_p4;
    }
    public List <DataBox> Checkbox = new List <DataBox>();


   [System.Serializable]
    public class ScrorBox
    {
        public Sprite Scror_0;
        public Sprite Scror_1;
        public Sprite Scror_2;
        public Sprite Scror_3;
    }
    public List <ScrorBox> Check_ScrorBox = new List <ScrorBox>();


    // public float[] Colores;
    // public List <Color> Colores = new List <Color>();
    

    public int player_id,Box_id,color_id;

    private void Start() {
        // Colores.Add(Color.white);
        // Colores.Add(Color.red);
        // Colores.Add(Color.blue);
        // Colores.Add(Color.green);
        // Colores.Add(Color.yellow);



        // Checkbox[1].Owner_p1 .material.color = Colores[4];
        
    }

    // HSVToRGB(H,S,V);  //h = 0 = แดง //s 0 = ขาว //h 232  น้ำเงิน
    public void testgame(){
        // showdata();
    }

    public void  showdata(){           
        switch(player_id){
            case 1:Checkbox[Box_id].num_p1 +=1;
                checkData();
                
                Debug.Log(" showdata player id =1");
            break;
            case 2:Checkbox[Box_id].num_p2 +=1;
                checkData();
                Debug.Log("showdata player id =2");
            break;
            case 3:Checkbox[Box_id].num_p3 +=1;
                checkData();
                Debug.Log("showdata player id =3");
            break;
            case 4:Checkbox[Box_id].num_p3 +=1;
                checkData();
                Debug.Log("showdata player id =4");
            break;

            }
        }



        public void checkData(){

            if(Checkbox[Box_id].num_p1 > 0) {
                Debug.Log("showdata num_p1");
                switch(Checkbox[Box_id].num_p1){
                    case 1 :                                                                            
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_1;  //coler_id_player
                    break;
                    case 2 :
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_2;               
                    break;
                    case 3 :
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_3;  
                    break;
                    default:
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_0;
                    break;   
                } 
            }
            if(Checkbox[Box_id].num_p2 > 0) {
                Debug.Log("showdata num_p2");
                switch(Checkbox[Box_id].num_p2){
                    case 1 :                                                                            
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_1;
                    break;
                    case 2 :
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_2;               
                    break;
                    case 3 :
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_3;  
                    break;
                    default:
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_0;
                    break;   
                } 
            }
                if(Checkbox[Box_id].num_p3 > 0) {
                    Debug.Log("showdata num_p3");
                switch(Checkbox[Box_id].num_p3){
                    case 1 :                                                                            
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_1;
                    break;
                    case 2 :
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_2;               
                    break;
                    case 3 :
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_3;  
                    break;
                    default:
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_0;
                    break;   
                } 
            }
                if(Checkbox[Box_id].num_p4 > 0) {
                    Debug.Log("showdata num_p4");
                switch(Checkbox[Box_id].num_p4){
                    case 1 :                                                                            
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_1;
                    break;
                    case 2 :
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_2;               
                    break;
                    case 3 :
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_3;  
                    break;
                    default:
                        Checkbox[Box_id].Owner_p1.sprite =  Check_ScrorBox[color_id].Scror_0;
                    break;   
                } 
            }
        }
    }








































    ///////////////////////////////////////////////
//     public MakePath framMakePath;
//     private testes ter = new testes();  
//     public int id_p,id_B;
//     void Start(){
//       ter.ok();
//     }

//     // void Update(){}

//     public void test_Program(){
//             // framMakePath.test_CheckData_Box(_id);
//             // framMakePath.test_CheckData_Box(_id);
//             framMakePath.CheckData_Box(id_p,id_B);
//     }

//     // public void testss(){
//     //     num[i] +=1; 
//     // }

//     public class testes : RandomDice{
//         public RandomDice  ran = new RandomDice();
//         public int  nnnn;

//         public void ok(){
//            nnnn = ran.t1;
//         //    Debug.Log("t1 =="+nnnn);
           
//         }

//     }
// }
