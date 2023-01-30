using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterShoot : MonoBehaviour
{
    public Camera horizontalCamera;
    public Camera shootingCamera;
    private GameObject canvas;



    private void OnTriggerEnter(Collider other){
        canvas = GameObject.Find("Canvas1");
        canvas.transform.Find("Cross").gameObject.SetActive(true);
        toShootingCamera();
    }

    public void toShootingCamera() {
        horizontalCamera.enabled = false;
        shootingCamera.enabled = true;
    }

}
