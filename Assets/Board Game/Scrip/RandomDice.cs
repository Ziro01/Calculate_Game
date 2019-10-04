using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomDice : MonoBehaviour
{
    // public SpriteRenderer Dice;     //show on sprite
    public Image Dice_i;                //show on image
    public List<Sprite> DiceSkin = new List<Sprite>(); //enter set_DiceSkin
    static  int min,max ;  //enter number min,max  is for random

    public int t1 =10;
    static  int showScre,showAnim; 
    bool swap;
    void Start(){  
        min = 1;
        max = DiceSkin.Count + 1;
        Dice_i.sprite = DiceSkin[showAnim];
    }

    // void Update() {}
    public void rungame(){
        swap = false;
    }
    public void click(){
        if(swap != true ){
            swap = true;
            StartCoroutine("swapDice");
        }
    }
    // private void FixedUpdate(){}
    static int numberRandom(){
        int number;
        number = Random.Range(min,max);
        return number;
    }
    public IEnumerator swapDice(){

        for(int i = 0; i <= 10; i++){
            showAnim = numberRandom() - 1;
            Dice_i.sprite = DiceSkin[showAnim];
            yield return new WaitForSeconds(0.05f);

            if(i==10){
                showScre = numberRandom();
                Debug.Log("showScre"+showScre);
                showAnim = showScre - 1;
                // Debug.Log("show[] Dice = "+showAnim);
                // swap = false;
                Dice_i.sprite = DiceSkin[showAnim];
            }
        }
    }
}
