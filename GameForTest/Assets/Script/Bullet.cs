using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;
using DG.Tweening;
public class Bullet : MonoBehaviour
{
    public LineRenderer lineRender;
    
    public LayerMask collisionMask;
    public Rigidbody rb;
    private float speed = 15;
    
   
   
    void Update()
    {
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Рикошет 
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Time.deltaTime * speed + .1f, collisionMask))
        {
            Vector3 reflectDir = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflectDir.z, reflectDir.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.tag == "coins")
        {
            Destroy(collision.gameObject);
        }
        if (collision.transform.tag == "walls")
        {
            Destroy(gameObject);
        }

    }

}
