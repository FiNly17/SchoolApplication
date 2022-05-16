using DataAccessLayer.IRepositories;
using ObjectLayer;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.IServices;

namespace BusinessLogicLayer.StrategyPattern
{
    public class Context<T>
        where T : class
    {
        private readonly IRepository<T> repository;
        private IComment comment;
        private readonly IStudentService studentService;

        public Context(IRepository<T> repository, IStudentService studentService)
        {
            this.repository = repository;
            this.studentService = studentService;
        }

        public async Task GetInformation()
        {
            IList<T> t = (await repository.GetAllAsync()).ToList();
            GetTypeData(t.Count);
            Console.WriteLine($"Table {t.First().GetType().Name} has {t.Count} records. {comment.ShowComment()}");
            if(comment is EmptyContext || comment is BetterAddContext)
            {
                StudentEntityModel student = new StudentEntityModel();
                Console.WriteLine("Введите имя: ");
                student.FirstName = Console.ReadLine();
                Console.WriteLine("Введите фамилию: ");
                student.LastName = Console.ReadLine();
                Console.WriteLine("Введите мобильный номер: ");
                student.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Введите адрес: ");
                student.Address = Console.ReadLine();
                if(t.First().GetType().Name == "StudentEntityModel")
                    studentService.CreateStudent(student);
            }
        }

        public void GetTypeData(int count)
        {
            if (count == 0)
                this.comment = new EmptyContext();
            if (count >= 1 && count <= 3)
                this.comment = new BetterAddContext();
            if (count > 3)
                this.comment = new EnoughContext();
        }
    }
}
