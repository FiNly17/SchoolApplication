using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IServices
{
    public interface IClassService
    {
        Task<IEnumerable<ClassEntityModel>> GetAllClasses();

        Task<ClassEntityModel> GetClassById(Guid id);

        bool DeleteClass(Guid id);

        void UpdateClass(ClassEntityModel classEntity);

        Task<ClassEntityModel> CreateClass(ClassEntityModel classEntity);
    }
}
