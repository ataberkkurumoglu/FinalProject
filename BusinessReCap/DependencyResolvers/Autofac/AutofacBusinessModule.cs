using Autofac;
using Autofac.Extras.DynamicProxy;
using BusinessReCap.Abstract;
using BusinessReCap.Concrete;
using Castle.DynamicProxy;
using CoreRecap.UtilitiesRecap.Interceptors;
using DataAccessReCap.Abstract;
using DataAccessReCap.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessReCap.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManagerReCap>().As<ICarService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
