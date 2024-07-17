using SchoolManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repository.DataRepositories
{
    public interface ISchoolRepo<T> where T : BaseEntity
    {
        int AddStudent(T _mdl);
        IEnumerable<T> GetAllStudent();
    }
}
