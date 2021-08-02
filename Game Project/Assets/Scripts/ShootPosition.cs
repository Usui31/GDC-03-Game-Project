using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPosition : MonoBehaviour
{
    public Transform ShootingPoint;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0){
            ShootingPoint.transform.localPosition = new Vector3(0.4f,-0.41f,0);
        }else if (Input.GetAxisRaw("Horizontal") < 0){
            
            ShootingPoint.transform.localPosition = new Vector3(-0.4f,-0.41f,0);
        }

        if (Input.GetAxisRaw("Vertical") > 0){
            ShootingPoint.transform.localPosition = new Vector3(0,0.03f,0);
        } else if (Input.GetAxisRaw("Vertical") < 0){
            ShootingPoint.transform.localPosition = new Vector3(0,-1.1f,0);
        }
    }
}
