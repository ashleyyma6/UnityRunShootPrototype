using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    private float mouseSensitivity = 100f;
    public Transform player;
    private float xRotate;
    private Vector3 cameraRotation;
    private Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cameraTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*mouseSensitivity*Time.deltaTime;
        cameraRotation.x -= mouseY;
        cameraRotation.x = Mathf.Clamp(cameraRotation.x, -80f,80f);
        cameraRotation.y += mouseX;
        cameraTransform.rotation = Quaternion.Euler(cameraRotation.x,cameraRotation.y+90f,0f);
        
    }
}