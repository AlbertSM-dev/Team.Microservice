using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Microservice.Card.Domain.Dtos;

namespace Team.Microservice.Card.Domain.Interfaces
{
    public interface ICardService
    {
        Task<IEnumerable<CardDto>> GetAllCardAsync();
        Task<CardDto?> GetCardByIdAsync(int id);
        Task<bool> CreateCardAsync(CardDto Card);
        Task<bool> UpdateCardAsync(CardDto Card);
        Task<bool> DeleteCardAsync(int id);
    }
}
