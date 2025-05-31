namespace MK.DependencyInjection
{
    using UnityEngine;

    public abstract class MonoScope : MonoBehaviour
    {
        public abstract void Configure(IBuilder builder);
    }
}