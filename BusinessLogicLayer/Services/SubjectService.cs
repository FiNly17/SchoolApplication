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
    public class SubjectService : ISubjectService
    {
        private readonly IRepository<SubjectEntityModel> repository;

        public SubjectService(IRepository<SubjectEntityModel> repository)
        {
            this.repository = repository;
        }

        public async Task<SubjectEntityModel> CreateSubject(SubjectEntityModel subject)
        {
            SubjectEntityModel subjectEntity = await repository.CreateAsync(subject);
            repository.Save();
            return subjectEntity;
        }

        public bool DeleteSubject(Guid id)
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

        public Task<IEnumerable<SubjectEntityModel>> GetAllSubjects()
        {
            return repository.GetAllAsync();
        }

        public Task<SubjectEntityModel> GetSubjectById(Guid id)
        {
            return repository.FindByIdAsync(id);
        }

        public void UpdateSubject(SubjectEntityModel subject)
        {
            repository.Update(subject);
            repository.Save();
        }
    }
}
