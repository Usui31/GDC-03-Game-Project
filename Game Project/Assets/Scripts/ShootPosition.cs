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
            ShootingPoint.transform.localPosition = new Vector3(0.622f,-0.221f,0);
        }else if (Input.GetAxisRaw("Horizontal") < 0){
            
            ShootingPoint.transform.localPosition = new Vector3(-0.596f,-0.207f,0);
        }

        if (Input.GetAxisRaw("Vertical") > 0){
            ShootingPoint.transform.localPosition = new Vector3(-0.024f,0.243f,0);
        } else if (Input.GetAxisRaw("Vertical") < 0){
            ShootingPoint.transform.localPosition = new Vector3(0.062f,-0.617f,0);
        }
    }
}
