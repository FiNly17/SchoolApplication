// See https://aka.ms/new-console-template for more information
using Autofac;
using Autofac.Integration.Mvc;
using BusinessLogicLayer.IServices;
using BusinessLogicLayer.Services;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ObjectLayer;
using SchoolApplication;
using System.Web.Mvc;


//Default DI with creating StartUp class
//IHost host = Host.CreateDefaultBuilder(args).Build();

//IConfiguration config = host.Services.GetRequiredService<IConfiguration>();
//IServiceCollection services = new ServiceCollection();
//StartUp startup = new StartUp(config);
//startup.ConfigureServices(services);
//IServiceProvider serviceProvider = services.BuildServiceProvider();

var container = ConfigureContainer();
var main = container.Resolve<MainOperations<StudentEntityModel>>();

StudentEntityModel student = new StudentEntityModel()
{
    FirstName = "Danik",
    LastName = "Finskiy",
    PhoneNumber = "+375295836320",
    Address = "Minsk"
};

await main.StrPattern();


//AutoFac
static IContainer ConfigureContainer()
{
    var builder = new ContainerBuilder();
    builder.RegisterType<SchoolContext>().AsSelf();

    builder.RegisterType<MainOperations<StudentEntityModel>>().AsSelf();
    builder.RegisterType<StudentService>().As<IStudentService>();
    builder.RegisterType<ClassService>().As<IClassService>();
    builder.RegisterType<SubjectService>().As<ISubjectService>();
    builder.RegisterType<Repository<StudentEntityModel>>().As<IRepository<StudentEntityModel>>();
    builder.RegisterType<Repository<SubjectEntityModel>>().As<IRepository<SubjectEntityModel>>();
    builder.RegisterType<Repository<ClassEntityModel>>().As<IRepository<ClassEntityModel>>();
    // Register all dependencies (and dependencies of those dependencies, etc)

    return builder.Build();
}

