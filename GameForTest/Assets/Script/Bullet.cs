using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;
using DG.Tweening;
public class Bullet : MonoBehaviour
{
    public LineRenderer lineRender;


    public Rigidbody rb;


    public GameObject go;
    private GameObject newLine;

    void Start()
    {

        go = GameObject.Find("Bezier");
        newLine = Instantiate(go);
        LineRenderer oldLine = go.GetComponent<LineRenderer>();
       

        Vector3[] newPos = new Vector3[oldLine.positionCount];

        oldLine.GetPositions(newPos);
        //Copy Old postion to the new LineRenderer
        newLine.GetComponent<LineRenderer>().SetPositions(newPos);


        gameObject.transform.DOPath(newPos, 1f, PathType.CatmullRom);

    }

    void Update()
    {


       


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
