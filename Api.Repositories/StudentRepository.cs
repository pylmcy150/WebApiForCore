using Api.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Models;
using Autofac;
using Api.Infrastructure;
using SqlSugar;

namespace Api.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _db;
        public StudentRepository(DataContext db)
        {
            _db = db;
        }

        public Student GetStudentById(string id)
        {
            using (var client = _db.Client())
            {
                var s = client.Queryable<Student>().Where(x => x.Id == id).SingleOrDefault();
                return s;
            }
        }

        public List<Student> GetStudents()
        {
            using (var client = _db.Client())
            {
                var s = client.Queryable<Student>().ToList();
                return s;
            }
        }

        public bool InsertStudent(Student student)
        {
            using (var client = _db.Client())
            {
                student.Id = Guid.NewGuid().ToString();
                var s = client.Insert<Student>(student);
                return (bool)s;
            }
        }
    }
}
