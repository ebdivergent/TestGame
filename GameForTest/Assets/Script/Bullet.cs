using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
  
 
    private void OnCollisionEnter (Collision collision)
    {
        //Debug.Log(collision.transform.name);
        if(collision.transform.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
        if (collision.transform.tag == "coins")
        {
            Destroy(collision.gameObject);
        }
        if (collision.transform.tag == "walls")
        {
            Destroy(gameObject);
        }

    }
    //protected float Animation;
    //Update is called once per frame
    void Update()
    {
        //Animation += Time.deltaTime;
        //Animation = Animation % 5f;
        //transform.position = MathParabola.Parabola(Vector3.zero, Vector3.forward * 10f, 5f, Animation / 5f);
        if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            GetComponent<ParabolaController>().FollowParabola();
        }

    }

}
