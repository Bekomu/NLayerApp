using Autofac;
using NLayer.Repository;
using NLayer.Service.Mapping;
using System.Reflection;
using Module = Autofac.Module; // ÖNEMLİİİİİİ -----

namespace NLayer.API.Modules
{
    public class RepoServiceModule : Module // autofac ten geldi
    {
        protected override void Load(ContainerBuilder builder)
        {
            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));


        }
    }
}
