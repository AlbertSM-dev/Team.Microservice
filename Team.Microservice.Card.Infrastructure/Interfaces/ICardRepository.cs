using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Microservice.Card.Infrastructure.Context.Entities;

namespace Team.Microservice.Card.Infrastructure.Interfaces
{
    public interface ICardRepository : IRepository<Cards>
    {
    }
}
