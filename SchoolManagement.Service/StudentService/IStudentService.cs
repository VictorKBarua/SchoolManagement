using SchoolManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Service.StudentService
{
    public interface IStudentService
    {
        int AddStudent(Student _mdlStudent);
        IEnumerable<Student> GetAllStudents();
    }
}
