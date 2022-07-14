using ContosoUniversity.DAL.IRepositories;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.Extensions.Logging;

namespace ContosoUniversity.DAL.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(SchoolContext context, ILogger logger)
            : base(context, logger)
        {

        }
    }
}
