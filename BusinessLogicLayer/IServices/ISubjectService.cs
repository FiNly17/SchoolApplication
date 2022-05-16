using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IServices
{
    public interface ISubjectService
    {
        Task<IEnumerable<SubjectEntityModel>> GetAllSubjects();

        Task<SubjectEntityModel> GetSubjectById(Guid id);

        bool DeleteSubject(Guid id);

        void UpdateSubject(SubjectEntityModel subject);

        Task<SubjectEntityModel> CreateSubject(SubjectEntityModel subject);
    }
}
