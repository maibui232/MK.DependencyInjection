namespace MK.DependencyInjection
{
    using global::VContainer.Unity;
    using VContainer.Unity;

    internal sealed class ProjectScope : VContainerScope
    {
#if UNITY_EDITOR
        private void OnValidate()
        {
            this.parentReference = new ParentReference();
        }
#endif
    }
}