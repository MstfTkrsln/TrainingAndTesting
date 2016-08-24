using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Castle.Core;
using Castle.DynamicProxy;
using Castle.Windsor;
using Component = Castle.MicroKernel.Registration.Component;

namespace AspectConsole
{
    public class Bootstrapper
    {
        public static IWindsorContainer Container { get; set; }

        public static void Initialize()
        {
            Container=new WindsorContainer();

            Container.Register(Component.For<IInterceptor>().ImplementedBy<OrderProcessorInterceptor>());

            Container.Register(
                Component.For<IOrderProcessor>()
                    .ImplementedBy<OrderProcessor>()
                    .Interceptors(InterceptorReference.ForType<OrderProcessorInterceptor>())
                    .Anywhere);
        }
    }
}
