namespace MK.DependencyInjection
{
    using System;
    using UnityEngine;
    using VContainer;
    using VContainer.Unity;

    internal class VContainerComponentRegister : VContainerRegister, IComponentRegister
    {
        public VContainerComponentRegister(IContainerBuilder builder, RegistrationBuilder registrationBuilder, Type implementType) : base(builder, registrationBuilder, implementType)
        {
        }

        IComponentRegister IComponentRegister.UnderTransform(Transform transform)
        {
            if (this.RegistrationBuilder is ComponentRegistrationBuilder componentRegistrationBuilder)
            {
                componentRegistrationBuilder.UnderTransform(transform);
            }

            return this;
        }

        IComponentRegister IComponentRegister.DontDestroyOnLoad()
        {
            if (this.RegistrationBuilder is ComponentRegistrationBuilder componentRegistrationBuilder)
            {
                componentRegistrationBuilder.DontDestroyOnLoad();
            }

            return this;
        }
    }
}