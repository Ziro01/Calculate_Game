using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public MakePath framMakePath;
    private testes ter = new testes();  
    public int id_p,id_B;
    void Start(){
      ter.ok();
    }

    // void Update(){}

    public void test_Program(){
            // framMakePath.test_CheckData_Box(_id);
            // framMakePath.test_CheckData_Box(_id);
            framMakePath.CheckData_Box(id_p,id_B);
    }

    // public void testss(){
    //     num[i] +=1; 
    // }

    public class testes : RandomDice{
        public RandomDice  ran = new RandomDice();
        public int  nnnn;

        public void ok(){
           nnnn = ran.t1;
           Debug.Log("t1 =="+nnnn);
           
        }

    }
}
