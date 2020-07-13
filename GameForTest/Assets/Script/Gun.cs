using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Runtime.CompilerServices;

public class Gun : MonoBehaviour
{
    public Transform bullet;
    
    public int BulletForce = 1000;
    public Transform parabolaPoint;
    
    private Camera mainCamera;
    
    public Vector2 startPos;
    public Vector3 direction;
    float pointMoovingSpeed = 0.001f;
    public GameObject parabora;
    
    public PathType pathSystem = PathType.CatmullRom;
    
    void Start()
    {
        //go = GameObject.Find("Bezier");
        //bc = go.GetComponent<BezierCurve>();
        
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToViewportPoint(touch.position);
            Shoot();
            switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    // Record initial touch position.
                    parabora.GetComponent<LineRenderer>().enabled = true;
                    startPos = touch.position;
                    break;
                //Determine if the touch is a moving touch
                case TouchPhase.Moved:
                    // Determine direction by comparing the current touch position with the initial one
                    direction.x = touch.position.x - startPos.x;
                    //if (parabolaPoint.position.x >= -10 && parabolaPoint.position.x <= 10)
                    //{
                        parabolaPoint.position += direction * pointMoovingSpeed;
                    //}

                    Shoot();
                    break;

                    
            }
        }



        void Shoot()
        {
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                
                //bullet.transform.DOPath(bc.positions, 31, pathSystem);
                Transform BulletInstance = (Transform)Instantiate(bullet, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
                BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
                parabora.GetComponent<LineRenderer>().enabled = false;
                FindObjectOfType<SoundManager>().Play("shoot");
                gameObject.SetActive(false);


            }
        }
    }
}

