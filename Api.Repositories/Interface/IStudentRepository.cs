using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Models;

namespace Api.Repositories.Interface
{
    public interface IStudentRepository
    {
        Student GetStudentById(string id);

        List<Student> GetStudents();

        bool InsertStudent(Student student);
    }
}
