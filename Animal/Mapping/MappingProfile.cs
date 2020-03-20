using Animal.Dtos;
using Animal.Models;
using Animal.Models.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AnimalRegistration, AnimalVM>();
            CreateMap<AnimalVM, AnimalRegistration>();
            CreateMap<AnimalRegistration, AnimalRegistrationDto>();
            CreateMap<FeedFooder, FeedFooderDto>();
            CreateMap<LrpVM, Lrp>();
            CreateMap<LrpVM, User>();
            CreateMap<GoatCreateVM, GoatRegistration>();
            CreateMap<GoatRegistration, GoatCreateVM>();
            CreateMap<IEnumerable<GoatRegistration>,IEnumerable<GoatIndexVM>>();
            CreateMap<VaccinationCreateVM, Vaccination>();
            CreateMap<Vaccination, VaccinationCreateVM>();
             CreateMap<VaccinationSubType, VaccinationSubTypeVM>();
            CreateMap<VaccinationSubTypeVM, VaccinationSubType>();
             CreateMap<VaccinationAnimal, VaccinAnimalCreateVM>();
            CreateMap<VaccinAnimalCreateVM,VaccinationAnimal>();
            CreateMap<Ai,AiCreateVM>();
            CreateMap<AiCreateVM,Ai>();

           

        }
    }
}
