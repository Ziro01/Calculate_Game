using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomDice : MonoBehaviour
{
    public static RandomDice fromRandomDice;
    // public SpriteRenderer Dice;     //show on sprite
    public Image Dice;                //show on image
    public List<Sprite> DiceSkin = new List<Sprite>(); //enter set_DiceSkin
    static  int min,max ;  //enter number min,max  is for random

    public int t1 =10;
    public  int showScre,showAnim,_numberRandom; 
    public bool swap;
    public bool play;
    private void Awake() 
    {
        fromRandomDice = this;
    }

    void Start()
    {  
        min = 1;
        max = DiceSkin.Count + 1;
        Dice.sprite = DiceSkin[showAnim];
        play = true;
    }
    public void rungame()
    {
        swap = false;
    }
    public void clickRandom()
    {

        if(swap != true )
        {
            swap = true;
            StartCoroutine("swapDice");
            // Debug.Log("clickRandom");
        }
    }
    static int numberRandom(){
        int number;
        number = Random.Range(min,max);
        return number;
    }
    public IEnumerator swapDice(){

        for(int i = 0; i <= 10; i++){
            showAnim = numberRandom() - 1;
            Dice.sprite = DiceSkin[showAnim];
            yield return new WaitForSeconds(0.05f);

            if(i==10){
                showScre = numberRandom();
                // Debug.Log("showScre"+showScre);
                showAnim = showScre - 1;
                Dice.sprite = DiceSkin[showAnim];
                _numberRandom = showScre;
                GameColtoler.fromGameColtoler.playGame(_numberRandom);
            }
        }
    }
}
