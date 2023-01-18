using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Microservice.Card.Domain.Dtos;
using Team.Microservice.Card.Infrastructure.Context.Entities;

namespace Team.Microservice.Card.Domain.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile() => CreateMap<Cards, CardDto>().ReverseMap();
    }
}
