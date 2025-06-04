namespace MK.DependencyInjection
{
    public interface IRegister
    {
        IRegister As<T>();
        IRegister As<T1, T2>();
        IRegister As<T1, T2, T3>();
        IRegister As<T1, T2, T3, T4>();
        IRegister AsSelf();
        IRegister AsImplementedInterfaces();
        IRegister WithParameters(params object[] parameters);
        void      NonLazy();
    }
}