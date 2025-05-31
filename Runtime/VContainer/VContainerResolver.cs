namespace MK.DependencyInjection
{
    using System;
    using global::VContainer;
    using global::VContainer.Internal;
    using global::VContainer.Unity;
    using UnityEngine;

    internal sealed class VContainerResolver : IResolver
    {
        private readonly IObjectResolver objectResolver;

        public VContainerResolver(IObjectResolver objectResolver)
        {
            this.objectResolver = objectResolver;
        }

        bool IResolver.Exists<T>()
        {
            return ((IResolver)this).Exists(typeof(T));
        }

        bool IResolver.Exists(Type type)
        {
            return this.objectResolver.TryResolve(type, out var resolved);
        }

        void IResolver.Inject(object instance)
        {
            this.objectResolver.Inject(instance);
        }

        T IResolver.Resolve<T>()
        {
            return this.objectResolver.Resolve<T>();
        }

        object IResolver.Resolve(Type type)
        {
            return this.objectResolver.Resolve(type);
        }

        T IResolver.Instantiate<T>()
        {
            return (T)((IResolver)this).Instantiate(typeof(T));
        }

        object IResolver.Instantiate(Type type)
        {
            return InjectorCache.GetOrBuild(type).CreateInstance(this.objectResolver, null);
        }

        T IResolver.InstantiatePrefab<T>(T prefab, Vector3 position, Quaternion rotation, Transform parent, bool worldPosition)
        {
            var obj = this.objectResolver.Instantiate(prefab, position, rotation, parent);

            if (worldPosition) return obj;
            obj.transform.SetLocalPositionAndRotation(position, rotation);

            return obj;
        }
    }
}