﻿using SchoolProject.Core.Features.Students.Queries.Response;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetStudentByIdMapping()
        {
            CreateMap<Student, GetSingleStudentResponse>()
                .ForMember(des => des.DepartmentName, opt => opt.MapFrom(src => src.Department.DName));
        }
    }
}
