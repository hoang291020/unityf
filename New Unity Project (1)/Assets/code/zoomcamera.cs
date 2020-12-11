using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomcamera : MonoBehaviour
{
    
    private Vector3 zoomCam = new Vector3(0,0,0.2f);
    private Vector3 rightcam = new Vector3(0.2f,0,0);
    private Vector3 upcam = new Vector3(0,0.2f,0);

    void FixedUpdate ()
    {
        if(Input.GetKey(KeyCode.O)){
           transform.position += zoomCam;
        } 
        if(Input.GetKey(KeyCode.I)){
           transform.position -= zoomCam;
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position -= rightcam;
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position += rightcam;
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position -= upcam;
        }
        if(Input.GetKey(KeyCode.W)){
            transform.position += upcam;
        }
    }
 
    
}
