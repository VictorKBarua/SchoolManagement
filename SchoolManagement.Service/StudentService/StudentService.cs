using SchoolManagement.Domain;
using SchoolManagement.Repository;
using SchoolManagement.Repository.DataRepositories;

namespace SchoolManagement.Service.StudentService
{
    public class StudentService : IStudentService
    {
        private ISchoolRepo<Student> _StudentRepositories;
        public StudentService(ISchoolRepo<Student> studentRepo)
        {
            _StudentRepositories = studentRepo;
        }

        public int AddStudent(Student _mdlStudent)
        {
            return _StudentRepositories.AddStudent(_mdlStudent);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _StudentRepositories.GetAllStudent();
        }

    }
}
