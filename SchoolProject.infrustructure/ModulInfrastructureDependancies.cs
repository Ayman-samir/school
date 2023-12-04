using Microsoft.Extensions.DependencyInjection;
using SchoolProject.infrustructure.Abstracts;
using SchoolProject.infrustructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.infrustructure
{
    public static class ModulInfrastructureDependancies
    {
        public static IServiceCollection AddInfrasturactureDependancies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
