namespace MK.DependencyInjection
{
    using System;
    using UnityEngine;

    public interface IBuilder
    {
        IRegister Register(Type type, Lifetime lifetime);

        IRegister Register<TService>(Lifetime lifetime);

        IRegister RegisterInstance(object instance);

        IComponentRegister RegisterComponentOnNewGameObject<TService>(Lifetime lifetime) where TService : Component;

        IComponentRegister RegisterComponentInNewPrefab<TService>(TService prefab, Lifetime lifetime) where TService : Component;

        IComponentRegister RegisterComponent<TService>() where TService : Component;
    }
}