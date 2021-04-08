using AutoMapper;
using GBCSporting2021_DynamicDevelopers.Models;
using GBCSporting2021_DynamicDevelopers.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_DynamicDevelopers.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Incident,IncidentsViewModel>();
            CreateMap<IncidentsViewModel, Incident>();
            CreateMap<Registration, RegistrationViewModel>();
            CreateMap<RegistrationViewModel, Registration>();
        }
    }
}
