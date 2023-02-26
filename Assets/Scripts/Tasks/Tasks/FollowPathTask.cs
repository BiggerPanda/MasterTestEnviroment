using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class FollowPathTask : Task
{
    [SerializeField] private SplineContainer path = null;
    [SerializeField] private GameObject highlightObject = null;
    [SerializeField] private GameObject currentPathPoint = null;
    [SerializeField] private float radius = 1f;

    private int currentPathIndex = 0;


    protected override void checkIfIsComplete()
    {
        if (currentPathIndex >= path.Spline.Count)
        {
            isComplete = true;
        }
    }
}
