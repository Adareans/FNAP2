using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public Camera office;
    public Camera Cam1;
    public Camera Cam2;
    public Camera Cam3;
    public Camera Cam4;

    void Start()
    {
        office.enabled = true;
        Cam1.enabled = false;
        Cam2.enabled = false;
        Cam3.enabled = false;
        Cam4.enabled = false;
    }

    void Update()
    {
        if(Input.GetKeyDown("1")){
            CamOne();
        }
        if(Input.GetKeyDown("2")){
            CamTwo();
        }
        if(Input.GetKeyDown("3")){
            CamThree();
        }
        if(Input.GetKeyDown("4")){
            CamFour();
        }
        if(Input.GetKeyDown("space")){
            CamMain();
        }

    void CamOne(){
        office.enabled = false;
        Cam1.enabled = true;
        Cam2.enabled = false;
        Cam3.enabled = false;
        Cam4.enabled = false;
    }
    void CamTwo(){
        office.enabled = false;
        Cam1.enabled = false;
        Cam2.enabled = true;
        Cam3.enabled = false;
        Cam4.enabled = false;
    }
    void CamThree(){
        office.enabled = false;
        Cam1.enabled = false;
        Cam2.enabled = false;
        Cam3.enabled = true;
        Cam4.enabled = false;
    }
    void CamFour(){
        office.enabled = false;
        Cam1.enabled = false;
        Cam2.enabled = false;
        Cam3.enabled = false;
        Cam4.enabled = true;
    }
    void CamMain(){
        office.enabled = true;
        Cam1.enabled = false;
        Cam2.enabled = false;
        Cam3.enabled = false;
        Cam4.enabled = false;
    }
    }  
        
}

