using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitShoot : MonoBehaviour
{
    public Camera horizontalCamera;
    public Camera shootingCamera;
    private GameObject canvas;

    private void OnTriggerEnter(Collider other){
        canvas = GameObject.Find("Canvas1");
        canvas.transform.Find("Cross").gameObject.SetActive(false);
        toHorizontalCamera();
    }

    public void toHorizontalCamera() {
        horizontalCamera.enabled = true;
        shootingCamera.enabled = false;
    }
}
