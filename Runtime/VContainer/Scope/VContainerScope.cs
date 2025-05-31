namespace MK.DependencyInjection
{
    using global::VContainer;
    using global::VContainer.Unity;
    using UnityEngine;
    using VContainer;
    using VContainer.Unity;

    public abstract class VContainerScope : LifetimeScope
    {
        [SerializeField] private MonoScope scope;

        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
            this.scope.Configure(new VContainerBuilder(builder));
        }
    }
}