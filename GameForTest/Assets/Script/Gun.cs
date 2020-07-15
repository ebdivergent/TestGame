using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Runtime.CompilerServices;

public class Gun : MonoBehaviour
{
    public Transform bullet;
    
    public int BulletForce = 200;
    public Transform parabolaPoint;
    
    private Camera mainCamera;
    
    public Vector2 startPos;
    public Vector3 direction;
    public Vector2 previousPosition;
    float pointMoovingSpeed = 10f;
    public GameObject parabora;
   


   
    void Update()
    {

#if !UNITY_EDITOR
    if (Input.touchCount > 0)
    {
        Touch touch = Input.GetTouch(0);
        Vector3 touchPosition = Camera.main.ScreenToViewportPoint(touch.position);

        switch (touch.phase)
        {
            case TouchPhase.Began:
                parabora.GetComponent<LineRenderer>().enabled = true;
                startPos = touch.position;
                break;

            case TouchPhase.Moved:

                
                direction.x  = (Input.mousePosition.x  - previousPosition.x) / Screen.width;

                parabolaPoint.position += direction * pointMoovingSpeed;


                
                break;
        }
    }
#else
        if (Input.GetMouseButtonDown(0))
        {
            parabora.GetComponent<LineRenderer>().enabled = true;
            startPos = Input.mousePosition;

        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 touchPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

            direction.x  = (Input.mousePosition.x  - previousPosition.x) / Screen.width;
            
            parabolaPoint.position += direction * pointMoovingSpeed;
           

        }
        else if (Input.GetMouseButtonUp(0))
        {
            Shoot();
        }
#endif
         void Shoot()
        {
            if (Input.GetMouseButtonUp(0))
            {

                
                Transform BulletInstance = (Transform)Instantiate(bullet, GameObject.Find("Point0").transform.position, Quaternion.identity);
                //BulletInstance.GetComponent<Rigidbody>().AddForce(transform.position * BulletForce);
                parabora.GetComponent<LineRenderer>().enabled = false;
                FindObjectOfType<SoundManager>().Play("shoot");
                gameObject.SetActive(false);


            }
        }

        previousPosition = Input.mousePosition;
    }
 
}

