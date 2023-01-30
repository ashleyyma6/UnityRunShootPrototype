using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Run : MonoBehaviour
{
    private float speed= 10f;
    private float turnSpeed = 5;
    private GameObject canvas;
    public bool GameStart = false;

    public Camera horizontalCamera;
    public Camera shootingCamera;

    private CharacterController characterController;
    private Vector3 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        canvas = GameObject.Find("Canvas1");
        canvas.transform.Find("FinishPanel").gameObject.SetActive(false);
        canvas.transform.Find("FailPanel").gameObject.SetActive(false);
        canvas.transform.Find("Cross").gameObject.SetActive(false);
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            if(!GameStart){
                canvas.transform.Find("StartPanel").gameObject.SetActive(false);
                GameStart = true;
            }else{
                SceneManager.LoadScene(0);
            }
            Time.timeScale = 1;
            return;
        }

        if(horizontalCamera.enabled && !shootingCamera.enabled){
            speed = 10f;
        }else{
            speed = 5f;
        }

        if(!horizontalCamera.enabled && shootingCamera.enabled){
            float x_h = Input.GetAxis("Horizontal");
            //float y_v = Input.GetAxis("Vertical");
            //moveDir=(transform.right*y_v + transform.forward*x_h*-1).normalized;
            transform.Translate(x_h*turnSpeed*Time.deltaTime,0,speed * Time.deltaTime);
        }else{
            float x = Input.GetAxis("Vertical")*-1;
            transform.Translate(x*turnSpeed*Time.deltaTime,0,speed * Time.deltaTime);
        }
        if(transform.position.z < -5 || transform.position.z > 5){
            transform.Translate(0,-10*Time.deltaTime,0);
        }
        if(transform.position.y<-5){
            Time.timeScale = 0;
            GameObject canvas = GameObject.Find("Canvas1");
            canvas.transform.Find("FailPanel").gameObject.SetActive(true);
        }
    }

}
