using AutoMapper;
using Moq;
using Team.Microservice.Card.Domain.Interfaces;
using Team.Microservice.Card.Domain.Mappings;
using Team.Microservice.Card.Domain.Services;
using Team.Microservice.Card.Infrastructure.Interfaces;

namespace Team.Microservice.Card.UnitTest
{
    public class CardUnitTest
    {
        private readonly ICardService service;
        private readonly Mock<IMapper> mockedMapper = new Mock<IMapper>();
        private readonly ICardRepository mockedCardRepository;

        [Fact]
        public void Should_GetAllCardAsync()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToDtoMappingProfile());
            });
            var mapper = config.CreateMapper();
            var repo = mockedCardRepository;
            var sut = new CardService(mapper, repo);

            // Act
            var result = sut.GetAllCardAsync();
            Assert.NotNull(result);
        }
    }
}