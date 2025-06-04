namespace MK.DependencyInjection
{
    using VContainer;
    using VContainer.Unity;

    internal sealed class ProjectScope : VContainerScope
    {
#if UNITY_EDITOR
        private void OnValidate()
        {
            this.parentReference = new ParentReference();
        }
#endif

        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<VContainerResolver>(VContainer.Lifetime.Singleton).AsImplementedInterfaces();
            base.Configure(builder);
        }
    }
}