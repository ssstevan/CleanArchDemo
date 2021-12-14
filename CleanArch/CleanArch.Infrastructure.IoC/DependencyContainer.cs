using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infrastructure.IoC
{
    //ovo ce sadrzati sve nase dependencije za razlicite projekte
    //cross cutting project koji ima dodirnih tacaka sa svim projektima koji imaju dependencis i za koje zelimo da povezemo sa njihovim concrete implementation
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application layer has dependency
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer 
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
