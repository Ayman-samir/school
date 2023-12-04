using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Response;
using SchoolProject.Data.Entities;
using SchoolProject.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler :ResponseHandler, 
                                     IRequestHandler<GetStudentListQuery,Response<List<GetStudentListResponse>>>,
                                     IRequestHandler<GetStudentByIdQuery, Response<GetSingleStudentResponse>>

    {
        #region Field
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        #endregion

        #region Ctor
        public StudentQueryHandler(IStudentService studentService,IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        #endregion

        #region Handle Functions
        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var students= await _studentService.GetStudentsListAsync();
            var studentListResponses = _mapper.Map<List<GetStudentListResponse>>(students);
            return Success(studentListResponses);
        }

        public async Task<Response<GetSingleStudentResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentById(request.Id);
            if (student == null) return NotFound<GetSingleStudentResponse>("Object Not Found");
            var result=_mapper.Map<GetSingleStudentResponse>(student);
            return Success(result);

        }
        #endregion

    }
}
