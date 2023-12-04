using SchoolProject.Data.Entities;
using SchoolProject.infrastructure.InfrastructureBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.infrustructure.Abstracts
{
    public interface IStudentRepository:IGenericRepositoryAsync<Student>
    {
        Task<List<Student>> GetStudentsLIstAsync();
    }
}
