using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    PlayerMovement pm;

    void Start(){
        pm = gameObject.GetComponent<PlayerMovement>();
    }
    // Update is called once per frame
    void Update()
    {
        if(!PauseMenu.isPaused){
            if (pm.posY == 0 && pm.posX != 0){
                if (pm.isFacingRight){
                    firePoint.transform.localEulerAngles = new Vector3(0,0,-90f);
                }else 
                    firePoint.transform.localEulerAngles = new Vector3(0,0,90f);
            } else if (pm.posX == 0 && pm.posY != 0){
                if (!pm.isFacingUp){
                    firePoint.transform.localEulerAngles = new Vector3(0,0,180f);
                }else
                    firePoint.transform.localEulerAngles = new Vector3(0,0,0);
            }
            
            if (Input.GetButtonDown("Fire1")){
                Shoot();
                FindObjectOfType<AudioManager>().Play("Tembak");
            }
        }
    }

    void Shoot(){
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
