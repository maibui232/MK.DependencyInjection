namespace MK.DependencyInjection
{
    using global::VContainer.Unity;
    using VContainer.Unity;

    public class SceneScope : VContainerScope
    {
#if UNITY_EDITOR
        private void OnValidate()
        {
            this.parentReference = ParentReference.Create<ProjectScope>();
        }
#endif
    }
}