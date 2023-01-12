using Microsoft.AspNetCore.Mvc;

namespace Team.Microservice.Card.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CardController : Controller
    {
        private readonly ICardService _service;
        private readonly ILogger<CardController> _logger;

        public CardController(ILogger<CardController> logger
            , ICardService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("GetAllCards")]
        [ProducesResponseType(typeof(IEnumerable<CardDto>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<CardDto>>> GetAllCards()
        {
            var result = await _service.GetAllCardsAsync();

            if (result.Any()) return Ok(result);

            _logger.LogInformation("Cards not found");
            return NotFound("Cards not found");
        }
    }
}
