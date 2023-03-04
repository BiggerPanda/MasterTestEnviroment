using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Splines;

public class FollowPathTask : Task
{
    [SerializeField] public SplineContainer path = null;
    [SerializeField] private GameObject highlightObject = null;
    [SerializeField] private GameObject currentPathPoint = null;
    [SerializeField] private float radius = 1f;
    [ReadOnly] private List<PathPoint> pathPoints = new List<PathPoint>();
    [ReadOnly] private int currentPathIndexToApproach = 0;

    private void Start()
    {
        int i = 0;
        foreach(PathPoint point in pathPoints)
        {
            point.SetPointID(i);
            i++;
        }
    }

    protected override void checkIfIsComplete()
    {
        if (currentPathIndexToApproach >= path.Spline.Count)
        {
            isComplete = true;
        }
    }

    public bool IncreasePathIndex(int pointIndex)
    {
        if (pointIndex == currentPathIndexToApproach)
        {
            currentPathIndexToApproach++;
            return true;
        }

        return false;
    }

    public void AddPathPoint(PathPoint point)
    {
        pathPoints.Add(point);
    }
}
