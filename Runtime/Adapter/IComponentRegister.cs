namespace MK.DependencyInjection
{
    using UnityEngine;

    public interface IComponentRegister : IRegister
    {
        IComponentRegister UnderTransform(Transform transform);
        IComponentRegister DontDestroyOnLoad();
    }
}