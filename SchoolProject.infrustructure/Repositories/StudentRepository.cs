using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.infrastructure.InfrastructureBase;
using SchoolProject.infrustructure.Abstracts;
using SchoolProject.infrustructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.infrustructure.Repositories
{
    public class StudentRepository :GenericRepositoryAsync<Student>, IStudentRepository
    {
        private readonly DbSet<Student> _students;
        public StudentRepository(ApplicationDbContext dbContext):base(dbContext)
        {
           _students = dbContext.Set<Student>();
            //_students = dbContext.Students;
        }
        public async Task<List<Student>> GetStudentsLIstAsync()
        {
            return await _students.Include(st=>st.Department).ToListAsync();
        }
    }
}
