namespace MK.DependencyInjection
{
    using VContainer.Unity;

    public sealed class SceneScope : VContainerScope
    {
#if UNITY_EDITOR
        private void OnValidate()
        {
#if MK_VCONTAINER
            
#endif
            this.parentReference = ParentReference.Create<ProjectScope>();
        }
#endif
    }
}