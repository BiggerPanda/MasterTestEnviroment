using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public abstract class Task : MonoBehaviour
{
    public bool isComplete = false;

    protected TaskManager taskManager = null;


    [Inject]
    private void Initialize(TaskManager _taskManager)
    {
        taskManager = _taskManager;
        taskManager.AddTask(this);
    }


    // Update is called once per frame
    protected virtual void Update()
    {
        if (isComplete)
        {
            return;
        }

        checkIfIsComplete();
    }

    protected abstract void checkIfIsComplete(); // This is the method that will be called in the Update method

}
