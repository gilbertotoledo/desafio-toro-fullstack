using Domain.Entities.SPB;

namespace Domain.Services.Interfaces
{
    public interface ISpbService
    {
        Task ProcessEventReceivedAsync(SpbEvent spbEvent);
    }
}
