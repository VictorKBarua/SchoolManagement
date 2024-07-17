using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain;
namespace SchoolManagement.Repository.DataRepositories
{
    public class SchoolRepo<T> : ISchoolRepo<T> where T : BaseEntity
    {
        private readonly SchoolContext _context;
        private readonly DbSet<T> _entities;

        public SchoolRepo(SchoolContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public int AddStudent(T _mdl)
        {
            if (_mdl == null) throw new ArgumentNullException("Object is null.");
            try
            {
                _entities.Add(_mdl);
                _context.SaveChanges();
                return _mdl.Id;
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException($"Error occured while storing object Data with error {ex.Message}.");
            }
        }

        public IEnumerable<T> GetAllStudent()
        {
            try
            {
                return _entities.AsEnumerable();
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException($"Error occured while retriving data with error {ex.Message}.");
            }
        }

    }
}
