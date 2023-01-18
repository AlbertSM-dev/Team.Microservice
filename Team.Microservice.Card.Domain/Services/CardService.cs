using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Microservice.Card.Domain.Dtos;
using Team.Microservice.Card.Domain.Interfaces;
using Team.Microservice.Card.Infrastructure.Interfaces;
using Team.Microservice.Card.Infrastructure.Context.Entities;

namespace Team.Microservice.Card.Domain.Services
{
    public class CardService : ICardService
    {
        private readonly IMapper _mapper;
        private readonly ICardRepository _cardRepository;

        public CardService(IMapper mapper, ICardRepository cardRepository)
        {
            _mapper = mapper;
            _cardRepository = cardRepository;
        }

        public Task<bool> CreateCardAsync(CardDto Card)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCardAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CardDto>> GetAllCardAsync()
        {
            var result = await _cardRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CardDto>>(result);
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
