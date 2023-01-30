using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // GameObject canvas = GameObject.Find("Canvas1");
        // canvas.transform.Find("FinishPanel").gameObject.SetActive(true);
        // Time.timeScale = 0;
    }

    private void OnTriggerEnter(Collider other){
        // trigger finish pannel
        GameObject canvas = GameObject.Find("Canvas1");
        canvas.transform.Find("FinishPanel").gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
