using BusinessLogicLayer.IServices;
using BusinessLogicLayer.Services;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication
{
    public class StartUp
    {
        public IConfiguration Configuration { get; }

        public StartUp(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //DefaultDI
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRepository<StudentEntityModel>, Repository<StudentEntityModel>>();
            services.AddScoped<IRepository<ClassEntityModel>, Repository<ClassEntityModel>>();
            services.AddScoped<IRepository<SubjectEntityModel>, Repository<SubjectEntityModel>>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IClassService, ClassService>();
            services.AddScoped<ISubjectService, SubjectService>();
        }
    }
}
