using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetposisionChamara : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
        posisionCam();
        
    }

    // Update is called once per frame
    // void Update() {}

    void posisionCam(){
        gameObject.transform.position = transform.position +new Vector3 (0f,0f,0f);


        // Debug.Log("position="+transform.position);
        // Debug.Log("rotation="+transform.rotation);
        // Debug.Log(transform.position);
        // cam.gameObject.transform.rotation = transform.rotation +new Vector3 (0f,0f,0f);
    }
}
