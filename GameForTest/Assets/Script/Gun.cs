using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bullet;
    
    public float damage = 10f;
    public int BulletForce = 1000;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            Shoot();
        }
    }
    void Shoot()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            Transform BulletInstance = (Transform)Instantiate(bullet, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
            BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
            Debug.Log("Piu");
        }
    }
}
