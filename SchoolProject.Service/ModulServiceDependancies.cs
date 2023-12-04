using Microsoft.Extensions.DependencyInjection;
using SchoolProject.infrustructure.Abstracts;
using SchoolProject.infrustructure.Repositories;
using SchoolProject.Service.IServices;
using SchoolProject.Service.Services;

namespace SchoolProject.Service
{
    public static class ModulServiceDependancies
    {
        public static IServiceCollection AddServiceDependancies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}