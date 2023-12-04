using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.infrustructure.Abstracts;
using SchoolProject.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Services
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;
        #endregion

        #region Ctor
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        #endregion

        #region Handel Method
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _studentRepository.GetStudentsLIstAsync();
        }
        public async Task<Student> GetStudentById(int id)
        {
            var student = _studentRepository
                .GetTableNoTracking()
                .Include(x => x.Department)
                .Where(st => st.StudID == id)
                .FirstOrDefault();
            return student;
        }

        #endregion

    }
}
