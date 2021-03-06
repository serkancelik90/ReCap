﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using ReCap.Business.Abstract;
using ReCap.Business.Concrete;
using ReCap.DataAccess.Abstract;
using ReCap.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.DepencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
            builder.RegisterType<CarImageManager>().As<ICarImageService>().SingleInstance();
            builder.RegisterType<EfCarImageDal>().As<ICarImageDal>().SingleInstance();
            builder.RegisterType<EfColorDal>().As<IColorDal>();
            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();
            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EfRentalDal>().As<IRentalDal>();
            builder.RegisterType<RentalManager>().As<IRentalService>();
            builder.RegisterType<EfCustomerDal>().As <ICustomerDal>();
            builder.RegisterType<CustomerManager>().As<ICustomerService>();


            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
