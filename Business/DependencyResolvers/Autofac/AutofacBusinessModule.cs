using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        //Uygulama ayağı kalktığında çalışacak metot
        protected override void Load(ContainerBuilder builder)
        {
            //IProductService isterse bir metot ona productManager ver demektir.
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            //IProductDal isterse(instance üretirse/global değişken tanımlarsa) EfProductDal ver demektir. 
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
