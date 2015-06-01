
using System.Reflection;
using System.Web.Mvc;
using SharpPatterns.Controllers;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

public static class DependencyConfig
{
    private static Container _container;

    public static void Register()
    {
        _container = new Container();
        _container.Register<ICustomerFactory, CustomerFactory>();

        _container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
        _container.RegisterMvcIntegratedFilterProvider();

        _container.Verify();

        DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(_container));
    }


    public static void Verify()
    {
        _container.Verify();
    }
}
