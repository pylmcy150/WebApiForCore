using Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    public interface IStudentManager
    {
        StudentDto Get(string id);

        List<StudentDto> GetList();

        void Add(StudentDto dto);
    }
}
