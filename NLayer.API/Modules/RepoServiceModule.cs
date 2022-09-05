using Autofac;
using NLayer.Service.Mapping;
using NLayer.Repository;
using System.Reflection;
using Module = Autofac.Module;
using NLayer.Core.Repositories;
using NLayer.Repository.Repositories;
using NLayer.Service.Services;
using NLayer.Core.Services;
using NLayer.Repository.UnitOfWorks;
using NLayer.Core.UnitOfWorks;
using NLayer.Cashing;

namespace NLayer.API.Modules
{
    public class RepoServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();


            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly,repoAssembly, serviceAssembly).Where(x=> x.Name.EndsWith
            ("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith
            ("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

        //    builder.RegisterType<ProductServiceWithCashing>().As<IProductService>();
        }
    }
}
