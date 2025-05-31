namespace MK.DependencyInjection
{
    using System;
    using UnityEngine;

    public interface IResolver
    {
        bool Exists<T>();

        bool Exists(Type type);

        void Inject(object instance);

        T Resolve<T>();

        object Resolve(Type type);

        T Instantiate<T>();

        object Instantiate(Type type);

        T InstantiatePrefab<T>(T prefab, Vector3 position = default, Quaternion rotation = default, Transform parent = null, bool worldPosition = false) where T : MonoBehaviour;
    }
}