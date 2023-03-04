using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectTask : Task
{
    [SerializeField] private GameObject objectToMove = null;
    [SerializeField] private Transform startPosition = null;
    [SerializeField] private Transform endPosition = null;
    [SerializeField] private float radiusFromCenter = 1f;


    private void OnEnable()
    {
        objectToMove.transform.position = startPosition.position;
    }

    protected override void checkIfIsComplete()
    {
        if (checkIfObjectIsInPositionRange())
        {
            isComplete = true;
        }
    }

    private bool checkIfObjectIsInPositionRange()
    {
        if (Vector3.Distance(objectToMove.transform.position, endPosition.position) <= radiusFromCenter)
        {
            return true;
        }

        return false;
    }
}