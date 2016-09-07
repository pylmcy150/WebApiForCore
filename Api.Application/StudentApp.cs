using Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Dto;
using Api.Repositories.Interface;
using AutoMapper;

namespace Api.Application
{
    public class StudentApp : IStudentManager
    {
        private readonly IStudentRepository _repository;

        public StudentApp(IStudentRepository repository)
        {
            _repository = repository;
        }

        public StudentDto Get(string id)
        {
            return Mapper.Map<StudentDto>(_repository.GetStudentById(id));
        }
    }
}
