namespace MK.DependencyInjection
{
    using System;
    using global::VContainer;

    internal class VContainerRegister : IRegister
    {
        protected readonly RegistrationBuilder RegistrationBuilder;
        private readonly   IContainerBuilder   builder;
        private readonly   Type                implementationType;

        private Type registrationType;

        public VContainerRegister(IContainerBuilder builder, RegistrationBuilder registrationBuilder, Type implementationType)
        {
            this.RegistrationBuilder = registrationBuilder;
            this.builder             = builder;
            this.implementationType  = implementationType;
        }

        IRegister IRegister.As<T>()
        {
            this.RegistrationBuilder.As<T>();
            this.registrationType = typeof(T);

            return this;
        }

        IRegister IRegister.As<T1, T2>()
        {
            this.RegistrationBuilder.As<T1, T2>();
            this.registrationType = typeof(T1);

            return this;
        }

        IRegister IRegister.As<T1, T2, T3>()
        {
            this.RegistrationBuilder.As<T1, T2, T3>();
            this.registrationType = typeof(T1);

            return this;
        }

        IRegister IRegister.As<T1, T2, T3, T4>()
        {
            this.RegistrationBuilder.As<T1, T2, T3, T4>();
            this.registrationType = typeof(T1);

            return this;
        }

        IRegister IRegister.AsSelf()
        {
            this.RegistrationBuilder.AsSelf();
            this.registrationType = this.implementationType;

            return this;
        }

        IRegister IRegister.AsImplementedInterfaces()
        {
            this.RegistrationBuilder.AsImplementedInterfaces();
            this.registrationType = this.implementationType;

            return this;
        }

        IRegister IRegister.WithParameters(params object[] parameters)
        {
            this.RegistrationBuilder.WithParameter(parameters);

            return this;
        }

        public void NonLazy()
        {
            this.builder.RegisterBuildCallback(resolver =>
                                               {
                                                   resolver.Resolve(this.registrationType);
                                               });
        }
    }
}