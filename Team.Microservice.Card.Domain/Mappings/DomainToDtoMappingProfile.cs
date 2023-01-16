using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Microservice.Card.Domain.Mappings
{
    public class DomainToDtoMappingProfile
    {
        CreateMap<Card, CardDto>().ReverseMap();
    }
}
