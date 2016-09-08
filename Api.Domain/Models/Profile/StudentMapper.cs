using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Api.Dto;

namespace Api.Domain.Models.Profile
{
    public class StudentMapper: AutoMapper.Profile
    {
        public StudentMapper()
        {
            base.CreateMap<Student, StudentDto>()
                .ForMember(desc => desc.Sex, opt => opt.MapFrom(src => src.Sex.HasValue ? (src.Sex.Value ? "男" : "女") : null));
            //.ConstructUsingServiceLocator();

            base.CreateMap<StudentDto, Student>()
                .ForMember(desc => desc.Sex, opt => opt.ResolveUsing<SexToBoolResolver>());
                //.ConstructUsingServiceLocator();
        }
    }

    public class SexToBoolResolver : IValueResolver<StudentDto, Student, bool?>
    {
        public bool? Resolve(StudentDto source, Student destination, bool? destMember, ResolutionContext context)
        {
            if (!string.IsNullOrWhiteSpace(source.Sex))
            {
                return source.Sex == "男" ? true : false;
            }
            else
            {
                return null;
            }
        }
    }
}
