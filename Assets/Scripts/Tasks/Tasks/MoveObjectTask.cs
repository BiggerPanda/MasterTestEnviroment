using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectTask : Task
{
    [SerializeField] private GameObject objectToMove = null;
    [SerializeField] private Transform startPosition = null;
    [SerializeField] private Transform endPosition = null;


    private void  OnEnable() 
    {
        objectToMove.transform.position = startPosition.position;    
    }

    protected override void checkIfIsComplete()
    {
        if (objectToMove.transform.position == endPosition.position)
        {
            isComplete = true;
        }
    }
}
