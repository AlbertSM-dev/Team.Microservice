using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Microservice.Card.Domain.Dtos;
using Team.Microservice.Card.Domain.Interfaces;

namespace Team.Microservice.Card.Domain.Services
{
    public class CardService : ICardService
    {
        public Task<bool> CreateCardAsync(CardDto Card)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCardAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CardDto>> GetAllCardAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CardDto?> GetCardByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCardAsync(CardDto Card)
        {
            throw new NotImplementedException();
        }
    }
}
