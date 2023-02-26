using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void RemoveTask(Task task)
    {
        tasks.Remove(task);
    }

    public bool AreAllTasksComplete()
    {
        foreach (Task task in tasks)
        {
            if (!task.isComplete)
            {
                return false;
            }
        }

        return true;
    }
}
