using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((GameObject.Find("T1")==null) && (GameObject.Find("T2")==null)){
            GameObject.Find("WallSet").SetActive(false);
        }

    }
    
}
