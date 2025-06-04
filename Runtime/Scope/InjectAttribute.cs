namespace MK.DependencyInjection
{
    using System;

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class InjectAttribute :
#if MK_VCONTAINER
        VContainer.InjectAttribute
#else
        System.Attribute
#endif
    {
    }
}