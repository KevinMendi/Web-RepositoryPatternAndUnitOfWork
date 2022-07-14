using ContosoUniversity.DAL.IRepositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace ContosoUniversity.DAL.IConfiguration
{
    public interface IUnitOfWork
    {
        IStudentRepository Students { get; }

        ICourseRepository Courses { get; }

        IDepartmentRepository Departments { get; }

        IInstructorRepository Instructors { get; }

        EntityEntry<T> Entry<T>([NotNullAttribute] T entity) where T : class;

        Task CompleteAsync();

        void Dispose();
    }
}
