using UnityEngine;
using Zenject;

public class TasksInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<TaskManager>().AsSingle();
    }
}