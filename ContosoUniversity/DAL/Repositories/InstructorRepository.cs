using ContosoUniversity.DAL.IRepositories;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.Extensions.Logging;

namespace ContosoUniversity.DAL.Repositories
{
    public class InstructorRepository : GenericRepository<Instructor>, IInstructorRepository
    {
        public InstructorRepository(SchoolContext context, ILogger logger)
            : base(context, logger)
        {

        }
    } 
}
