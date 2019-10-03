using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame updat
    MakePath Players = new MakePath();
    void Start()
    {
        Debug.Log(Players.point.Length);
    //    int t =  MakePath.fromMakePath.n;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
