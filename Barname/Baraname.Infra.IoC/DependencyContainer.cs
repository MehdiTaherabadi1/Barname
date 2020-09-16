using Baraname.Application.Interfaces;
using Baraname.Application.Services;
using CleanArch.Domin.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Baraname.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection service)
        {
            service.AddScoped<ICourseService, CourseServices>();

            service.AddScoped<ICourseRepository, CourseRepositroy>();
        }
    }
}