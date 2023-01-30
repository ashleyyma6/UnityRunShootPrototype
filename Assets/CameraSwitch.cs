using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera horizontalCamera;
    public Camera shootingCamera;

    public void toShootingCamera() {
        horizontalCamera.enabled = false;
        shootingCamera.enabled = true;
    }
    public void toHorizontalCamera() {
        horizontalCamera.enabled = true;
        shootingCamera.enabled = false;
    }

}
