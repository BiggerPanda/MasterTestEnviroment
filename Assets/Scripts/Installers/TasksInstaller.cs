using UnityEngine;
using Zenject;

public class TasksInstaller : MonoInstaller
{
    [SerializeField] private TaskManager taskManager;

    public override void InstallBindings()
    {
        Container.BindInstance(taskManager).AsSingle();
    }
}