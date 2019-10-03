using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//managrt gamecontoler//
public class GameColtoler : MonoBehaviour
{    
    // Randomnumber Randoms = new Randomnumber();
    public int playereing;
    public bool play;
    // Start is called before the first frame update
    public  List<MakePath>  player = new List<MakePath>();
    void Start()
    {
        player[playereing].testP1(1111);

        player[playereing].testP1(22222);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void terbPlate(){
        if(play == true){
            

        }

    }
}
