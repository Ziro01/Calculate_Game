using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public static Board fromBoard;
    public List<GameObject> poin = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        fromBoard = this;
    }
  

    // Update is called once per frame
    // void Update(){ }
    public void test(){
        Debug.Log("test");
    }

    public void show_taget( int min,int max){
        for(int i = min; i < max; i++ ){
            poin[i].gameObject.SetActive(true);
        }
    }
}
