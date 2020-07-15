using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BezierCurve : MonoBehaviour
{
    public LineRenderer lineRender;
    public int numPoints = 30;
    public Vector3[] positions = new Vector3 [30];
    public Transform point0,
                     point1,
                     point2;
    
    Bullet b;
    // Start is called before the first frame update
    void Start()
    {
        
        lineRender.positionCount = numPoints;
        
        DrawQuadraticCurve();
        
    }

    // Update is called once per frame
    void Update()
    {
        DrawQuadraticCurve();
        
    }
    

    private void DrawQuadraticCurve()
    {
        for (int i = 1; i < numPoints + 1; i++)
        {
            float t = i / (float)numPoints;
            positions[i - 1] = CalculateQuadraticBezierPoint(t, point0.position, point1.position, point2.position);

        }
        lineRender.SetPositions(positions);
        

    }


    private Vector3 CalculateQuadraticBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
    {
        float u = 1 - t,
              tt = t * t,
              uu = u * u;
        Vector3 p = uu * p0;
        p += 2 * u * t * p1;
        p += tt * p2;
        return p;

    }
   
    //public void Dots(Vector3[] positions)
    //{
    //    lineRender.GetPositions(positions);
    //}

}

