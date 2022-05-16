using BusinessLogicLayer.IServices;
using BusinessLogicLayer.StrategyPattern;
using DataAccessLayer.IRepositories;
using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication
{
    public class MainOperations<T>
        where T : class
    {
        private readonly IRepository<T> repository;
        private readonly IStudentService studentService;

        public MainOperations(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public async Task StrPattern()
        {
            Context<T> pat = new Context<T>(repository, studentService);
            await pat.GetInformation();
        }

        //public async Task<StudentEntityModel> CreateStudent(StudentEntityModel student)
        //{
        //    return await studentService.CreateStudent(student);
        //}
    }
}
