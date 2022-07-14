using ContosoUniversity.DAL.IRepositories;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.Extensions.Logging;

namespace ContosoUniversity.DAL.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolContext context, ILogger logger)
            : base(context, logger)
        {

        }
    }
}
