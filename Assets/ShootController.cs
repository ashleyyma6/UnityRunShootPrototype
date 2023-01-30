using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    private int range = 100;
    public Camera cam;
    private Vector3 point;
    
    // Start is called before the first frame update
    void Start()
    {
        point = new Vector3(Screen.width/2, Screen.height/2,0);
    }

    // Update is called once per frame
    void Update()
    {
        bool fire = Input.GetMouseButton(0);
        if(fire){
            //Debug.Log("shoot");
            GunFire();
        }
    }

    private void GunFire(){
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(point);
        if(Physics.Raycast(ray, out hit, range)){
            if(hit.transform.name == "T1"){
                GameObject.Find("T1").SetActive(false);
            }
            if(hit.transform.name == "T2"){
                GameObject.Find("T2").SetActive(false);
            }
            //Debug.Log(hit.transform.name);
        }
    }

}
