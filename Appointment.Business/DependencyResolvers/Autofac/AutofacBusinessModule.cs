using Appointment.Business.Concretes;
using Appointment.Business.Interfaces;
using Appointment.DataAccess.Abstract;
using Appointment.DataAccess.Concrete.EntityFramework;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Appointment.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SessionManager>().As<ISessionService>();
            builder.RegisterType<EfSessionDal>().As<ISessionDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions
            {
                Selector = new AspectInterceptorSelector()

            }).SingleInstance();
        }
    }
}
