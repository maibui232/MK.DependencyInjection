namespace MK.DependencyInjection
{
    using System;
    using VContainer;
    using VContainer.Unity;

    internal sealed class VContainerBuilder : IBuilder
    {
        private readonly IContainerBuilder builder;

        public VContainerBuilder(IContainerBuilder builder)
        {
            this.builder = builder;
        }

        public IRegister Register(Type type, Lifetime lifetime)
        {
            return new VContainerRegister(this.builder.Register(type, lifetime.FromVContainer()));
        }

        IRegister IBuilder.Register<TService>(Lifetime lifetime)
        {
            return new VContainerRegister(this.builder.Register<TService>(lifetime.FromVContainer()));
        }

        IRegister IBuilder.RegisterInstance(object instance)
        {
            return new VContainerRegister(this.builder.RegisterInstance(instance));
        }

        IComponentRegister IBuilder.RegisterComponentOnNewGameObject<TService>(Lifetime lifetime)
        {
            return new VContainerComponentRegister(this.builder.RegisterComponentOnNewGameObject<TService>(lifetime.FromVContainer()));
        }

        IComponentRegister IBuilder.RegisterComponentInNewPrefab<TService>(TService prefab, Lifetime lifetime)
        {
            return new VContainerComponentRegister(this.builder.RegisterComponentInNewPrefab(prefab, lifetime.FromVContainer()));
        }

        IComponentRegister IBuilder.RegisterComponent<TService>()
        {
            return new VContainerComponentRegister(this.builder.RegisterComponent(typeof(TService)));
        }
    }
}