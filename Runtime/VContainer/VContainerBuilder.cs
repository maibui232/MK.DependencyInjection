namespace MK.DependencyInjection
{
    using System;
    using VContainer;
    using VContainer.Unity;

    public sealed class VContainerBuilder : IBuilder
    {
        private readonly IContainerBuilder builder;

        public VContainerBuilder(IContainerBuilder builder)
        {
            this.builder = builder;
        }

        public IRegister Register(Type type, Lifetime lifetime)
        {
            return new VContainerRegister(this.builder, this.builder.Register(type, lifetime.FromVContainer()), type);
        }

        IRegister IBuilder.Register<TService>(Lifetime lifetime)
        {
            return new VContainerRegister(this.builder, this.builder.Register<TService>(lifetime.FromVContainer()), typeof(TService));
        }

        IRegister IBuilder.RegisterInstance(object instance)
        {
            return new VContainerRegister(this.builder, this.builder.RegisterInstance(instance), instance.GetType());
        }

        IComponentRegister IBuilder.RegisterComponentOnNewGameObject<TService>(Lifetime lifetime)
        {
            return new VContainerComponentRegister(this.builder, this.builder.RegisterComponentOnNewGameObject<TService>(lifetime.FromVContainer()), typeof(TService));
        }

        IComponentRegister IBuilder.RegisterComponentInNewPrefab<TService>(TService prefab, Lifetime lifetime)
        {
            return new VContainerComponentRegister(this.builder, this.builder.RegisterComponentInNewPrefab(prefab, lifetime.FromVContainer()), typeof(TService));
        }

        IComponentRegister IBuilder.RegisterComponent<TService>()
        {
            return new VContainerComponentRegister(this.builder, this.builder.RegisterComponent(typeof(TService)), typeof(TService));
        }
    }
}