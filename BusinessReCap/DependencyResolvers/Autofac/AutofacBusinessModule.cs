using Autofac;
using BusinessReCap.Abstract;
using BusinessReCap.Concrete;
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
        }
    }
}
