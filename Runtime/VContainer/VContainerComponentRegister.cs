namespace MK.DependencyInjection
{
    using UnityEngine;
    using VContainer;
    using VContainer.Unity;

    internal class VContainerComponentRegister : VContainerRegister, IComponentRegister
    {
        public VContainerComponentRegister(RegistrationBuilder registrationBuilder) : base(registrationBuilder)
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