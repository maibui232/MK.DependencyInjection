namespace MK.DependencyInjection
{
    using global::VContainer;

    internal class VContainerRegister : IRegister
    {
        protected readonly RegistrationBuilder RegistrationBuilder;

        public VContainerRegister(RegistrationBuilder registrationBuilder)
        {
            this.RegistrationBuilder = registrationBuilder;
        }

        IRegister IRegister.As<T>()
        {
            this.RegistrationBuilder.As<T>();

            return this;
        }

        IRegister IRegister.As<T1, T2>()
        {
            this.RegistrationBuilder.As<T1, T2>();

            return this;
        }

        IRegister IRegister.As<T1, T2, T3>()
        {
            this.RegistrationBuilder.As<T1, T2, T3>();

            return this;
        }

        IRegister IRegister.As<T1, T2, T3, T4>()
        {
            this.RegistrationBuilder.As<T1, T2, T3, T4>();

            return this;
        }

        IRegister IRegister.AsSelf()
        {
            this.RegistrationBuilder.AsSelf();

            return this;
        }

        IRegister IRegister.AsImplementedInterfaces()
        {
            this.RegistrationBuilder.AsImplementedInterfaces();

            return this;
        }

        IRegister IRegister.WithParameters(params object[] parameters)
        {
            this.RegistrationBuilder.WithParameter(parameters);

            return this;
        }
    }
}