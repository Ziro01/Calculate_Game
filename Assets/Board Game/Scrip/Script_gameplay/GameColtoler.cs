using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//managrt gamecontoler//
public class GameColtoler : MonoBehaviour
{    
    public int playering;
    public  List<Player>  player = new List<Player>();
    public RandomDice Dice;

    public void playGame(){

        switch (player[playering].live){

            case true:
                player[playering].playGame();
                run_turn();

            break;

            case false :
                run_turn();
            break;
        }
    }
    public void run_turn(){
        playering = (playering + 1) % player.Count;
    }  
}
public class _Dice : RandomDice 
{    
    public RandomDice  _random = new RandomDice();


    // public void 


}
