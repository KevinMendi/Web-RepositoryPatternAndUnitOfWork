using ContosoUniversity.DAL.IConfiguration;
using ContosoUniversity.DAL.IRepositories;
using ContosoUniversity.DAL.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly SchoolContext _context;
        private readonly ILogger _logger;

        public IStudentRepository Students { get; private set; }

        public ICourseRepository Courses { get; private set; }

        public IDepartmentRepository Departments { get; private set; }

        public IInstructorRepository Instructors { get; private set; }

        public UnitOfWork(SchoolContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");
            Students = new StudentRepository(_context, _logger);
            Courses = new CourseRepository(_context, _logger);
            Departments = new DepartmentRepository(_context, _logger);
            Instructors = new InstructorRepository(_context, _logger);
        }

        public EntityEntry<T> Entry<T>(T entity) where T : class
        {
            return _context.Entry<T>(entity);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
