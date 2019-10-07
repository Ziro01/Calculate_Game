using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetposisionChamara : MonoBehaviour
{
    // Start is called before the first frame update

   SpriteRenderer test;
    void Start()
    {
        test = GetComponent<SpriteRenderer>();

        Invoke("test_nnll",10f);
    }

    void test_nnll(){
      test.sprite = null;
      Debug.Log("jjjjjjjjjj");
    }


}
