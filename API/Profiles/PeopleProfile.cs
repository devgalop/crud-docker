using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Entities;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class PeopleProfile : Profile
    {
        public PeopleProfile()
        {
            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Person, AddPersonDto>().ReverseMap();
        }
    }
}