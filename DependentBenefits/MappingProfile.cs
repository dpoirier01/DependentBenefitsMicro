using AutoMapper;
using DependentBenefits.Commands.Data;
using DependentBenefits.Commands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependentBenefits
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddNewDependent, Dependent>();
        }
    }
}
