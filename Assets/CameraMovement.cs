using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 eulerAngles;
    // Start is called before the first frame update
    void Start()
    {
        //Add debug logs with Debug.Log("text");
        Debug.Log("Text");
    }
    bool wStopped = true;
    bool aStopped = true;
    bool sStopped = true;
    bool dStopped = true;
    bool spaceStopped = true;
    bool shiftStopped = true;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("g")){
            rb.useGravity = !rb.useGravity;
        }
        if(Input.GetKey(KeyCode.W) == true && wStopped && rb.position.z > -9.5){
            rb.AddForce(0, 0, -100);
            wStopped = false;
        }
        if(!Input.GetKey(KeyCode.W) || rb.position.z <= -9.5){
            if(!wStopped){
                rb.AddForce(0, 0, 100);
            }
            wStopped = true;
        }
        if(Input.GetKey(KeyCode.S) == true && sStopped  && rb.position.z < 8.5){
            rb.AddForce(0, 0, 100);
            sStopped = false;
        }
        if(!Input.GetKey(KeyCode.S) || rb.position.z >= 8.5){
            if(!sStopped){
                rb.AddForce(0, 0, -100);
            }
            sStopped = true;
        }
        if(Input.GetKey(KeyCode.A) == true && aStopped && rb.position.x < 8){
            rb.AddForce(100, 0, 0);
            aStopped = false;
        }
        if(!Input.GetKey(KeyCode.A) || rb.position.x >= 8){
            if(!aStopped){
                rb.AddForce(-100, 0, 0);
            }
            aStopped = true;
        }
        if(Input.GetKey(KeyCode.D) == true && dStopped && rb.position.x > -7){
            rb.AddForce(-100, 0, 0);
            dStopped = false;
        }
        if(!Input.GetKey(KeyCode.D) || rb.position.x <= -7){
            if(!dStopped){
                rb.AddForce(100, 0, 0);
            }
            dStopped = true;
        }
        if(Input.GetKey(KeyCode.Space) == true && spaceStopped && rb.position.y < 11){
            rb.AddForce(0, 100, 0);
            spaceStopped = false;
        }
        if(!Input.GetKey(KeyCode.Space) || rb.position.y >= 11){
            if(!spaceStopped){
                rb.AddForce(0, -100, 0);
            }
            spaceStopped = true;
        }
        if(Input.GetKey(KeyCode.LeftShift) == true && shiftStopped && rb.position.y > 5){
            rb.AddForce(0, -100, 0);
            shiftStopped = false;
        }
        if(!Input.GetKey(KeyCode.LeftShift) || rb.position.y <= 5){
            if(!shiftStopped){
                rb.AddForce(0, 100, 0);
            }
            shiftStopped = true;
        }
        transform.eulerAngles = new Vector3(90, 0, 180);
    }
}
