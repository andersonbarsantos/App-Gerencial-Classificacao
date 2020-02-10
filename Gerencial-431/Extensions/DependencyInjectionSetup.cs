using System;
using AppGerencial.Infrastructure.CrossCutting.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Gerencial_431.UI.Web.Extensions
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjectorInfrastructure.RegisterServices(services);
        }
    }
}