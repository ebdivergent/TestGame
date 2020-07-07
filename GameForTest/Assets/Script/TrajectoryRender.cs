using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRender : MonoBehaviour
{
    private LineRenderer lineRenderComponent;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderComponent = GetComponent<LineRenderer>();

    }

    public void ShowTrajectory(Vector3 origin, Vector3 speed)
    {
        Vector3[] points = new Vector3[100];
        lineRenderComponent.positionCount = points.Length;
        for (int i = 0; i< points.Length; i++)
        {
            float time = i * 0.1f;
            points[i] = origin + speed*time+Physics.gravity*time *time /2f;
        }
        lineRenderComponent.SetPositions(points);
    }
}
