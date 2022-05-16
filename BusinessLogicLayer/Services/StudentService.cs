using BusinessLogicLayer.IServices;
using DataAccessLayer.IRepositories;
using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<StudentEntityModel> repository;

        public StudentService(IRepository<StudentEntityModel> repository)
        {
            this.repository = repository;
        }

        public async Task<StudentEntityModel> CreateStudent(StudentEntityModel student)
        {
            StudentEntityModel studentEntity = await repository.CreateAsync(student);
            repository.Save();
            return studentEntity;
        }

        public bool DeleteStudent(Guid id)
        {
            try
            {
                repository.Delete(id);
                repository.Save();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Task<IEnumerable<StudentEntityModel>> GetAllStudents()
        {
            return repository.GetAllAsync();
        }

        public Task<StudentEntityModel> GetStudentById(Guid id)
        {
            return repository.FindByIdAsync(id);
        }

        public void UpdateStudent(StudentEntityModel student)
        {
            repository.Update(student);
            repository.Save();
        }
    }
}
