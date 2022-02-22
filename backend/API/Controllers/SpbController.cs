using Dawn;
using Domain.Entities.SPB;
using Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("spb")]
    [ApiController]
    public class SpbController : ControllerBase
    {
        private readonly ISpbService _spbService;

        public SpbController(ISpbService spbService)
        {
            _spbService = spbService;
        }

        [HttpPost("events")]
        public async Task<IActionResult> Post(SpbEvent spbEvent)
        {
            try
            {
                Guard.Argument(spbEvent, nameof(spbEvent)).NotNull();
                Guard.Argument(spbEvent.Event, nameof(spbEvent.Event)).NotNull();
                Guard.Argument(spbEvent.Target, nameof(spbEvent.Target)).NotNull();
                Guard.Argument(spbEvent.Origin, nameof(spbEvent.Origin)).NotNull();
                                
                await _spbService.ProcessEventReceivedAsync(spbEvent);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

