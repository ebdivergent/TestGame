using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour
{
    public Transform bullet;
    public TrajectoryRender Trajectory;
    public int BulletForce = 1000;
    public Transform parabolaPoint;
    float startTwoPoint;
    private Camera mainCamera;
    int pos = 0;
    public Vector2 startPos;
    public Vector3 direction;

    void Start()
    {
        startTwoPoint = parabolaPoint.position.x;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToViewportPoint(touch.position);
            //switch (touch.phase)
            //{
            //    //When a touch has first been detected, change the message and record the starting position
            //    case TouchPhase.Began:
            //        // Record initial touch position.
            //        startPos = touch.position;
            //        break;
            //    //Determine if the touch is a moving touch
            //    case TouchPhase.Moved:
            //        // Determine direction by comparing the current touch position with the initial one
            //        direction.x = Math.Abs(touch.position.x - startPos.x);
            //        for(int i=0; i<direction.x; i++)
            //        { 
            //            startTwoPoint++;
            //        }
                    
            //        Debug.Log(direction.x + " Direction");
            //        break;
                    
            //    case TouchPhase.Ended:
            //        // Report that the touch has ended when it ends
            //        break;
            //}
            //if(touchPosition.x < 0.5 )
            //{
            //    pos--;
            //    Debug.Log(pos+" Levo");
            //}
            //if(touchPosition.x > 0.5)
            //{
            //    pos++;
            //    Debug.Log(pos+" Pravo");
            //}



            Shoot();

        }

    }
   
    void Shoot()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            
            
            Transform BulletInstance = (Transform)Instantiate(bullet, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
            BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
            //Debug.Log("Piu");

        }
    }

}
