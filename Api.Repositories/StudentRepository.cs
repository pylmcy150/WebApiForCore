using Api.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Models;
using Autofac;

namespace Api.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository(SqlSugar.SqlSugarClient client)
        {

        }

        public Student GetStudentById(string id)
        {
            Student s = new Student();
            
            throw new NotImplementedException();
        }
    }
}
