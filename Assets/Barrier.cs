using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        // Debug.Log("trigger");
        if(other.name == "Player"){
            Time.timeScale = 0;
            GameObject canvas = GameObject.Find("Canvas1");
            canvas.transform.Find("FailPanel").gameObject.SetActive(true);
        }
    }
}
