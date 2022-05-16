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
    public class ClassService : IClassService
    {
        private readonly IRepository<ClassEntityModel> repository;

        public ClassService(IRepository<ClassEntityModel> repository)
        {
            this.repository = repository;
        }

        public async Task<ClassEntityModel> CreateClass(ClassEntityModel classEntity)
        {
            ClassEntityModel classEntityModel = await repository.CreateAsync(classEntity);
            repository.Save();
            return classEntityModel;
        }

        public bool DeleteClass(Guid id)
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

        public Task<IEnumerable<ClassEntityModel>> GetAllClasses()
        {
            return repository.GetAllAsync();
        }

        public Task<ClassEntityModel> GetClassById(Guid id)
        {
            return repository.FindByIdAsync(id);
        }

        public void UpdateClass(ClassEntityModel classEntity)
        {
            repository.Update(classEntity);
            repository.Save();
        }
    }
}
