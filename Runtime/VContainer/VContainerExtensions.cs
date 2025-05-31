namespace MK.DependencyInjection
{
    using System;

    internal static class VContainerExtensions
    {
        public static VContainer.Lifetime FromVContainer(this Lifetime lifetime)
        {
            return lifetime switch
                   {
                       Lifetime.Singleton => VContainer.Lifetime.Singleton,
                       Lifetime.Transient => VContainer.Lifetime.Transient,
                       _                  => throw new ArgumentOutOfRangeException(nameof(lifetime), lifetime, null)
                   };
        }
    }
}