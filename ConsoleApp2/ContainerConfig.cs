using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp2
{
    public static class ContainerConfig
    {

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<DataAccess>().As<IDataAccess>();
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
            //    .Where(t => t.Namespace.Contains)
            return builder.Build();
        }
    }
}






