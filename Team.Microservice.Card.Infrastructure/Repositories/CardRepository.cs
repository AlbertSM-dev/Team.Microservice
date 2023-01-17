using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Microservice.Card.Infrastructure.Context;
using Team.Microservice.Card.Infrastructure.Context.Entities;
using Team.Microservice.Card.Infrastructure.Interfaces;

namespace Team.Microservice.Card.Infrastructure.Repositories
{
    public class CardRepository : Repository<Card>, ICardRepository
    {
        public CardRepository(ApplicationDbContext context) : base(context)
        { 
        }
    }
}
