using ContosoUniversity.DAL.IRepositories;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.Extensions.Logging;

namespace ContosoUniversity.DAL.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(SchoolContext context, ILogger logger)
            : base(context, logger)
        {

        }
    }
}
