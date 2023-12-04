using Microsoft.Extensions.DependencyInjection;
using SchoolProject.infrastructure.InfrastructureBase;
using SchoolProject.infrustructure.Abstracts;
using SchoolProject.infrustructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core
{
    public static class ModulCoreDependancies
    {
        public static IServiceCollection AddInModulCoreDependancies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            // Configure AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); // Reference your AutoMapperConfig class

            //register genric repos
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

            return services;
        }
    }
}
