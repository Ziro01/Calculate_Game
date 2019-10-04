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
        player[playering].playGame();
        run_turn();
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
