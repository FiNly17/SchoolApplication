using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IServices
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentEntityModel>> GetAllStudents();

        Task<StudentEntityModel> GetStudentById(Guid id);

        bool DeleteStudent(Guid id);

        void UpdateStudent(StudentEntityModel student);

        Task<StudentEntityModel> CreateStudent(StudentEntityModel student);
    }
}
