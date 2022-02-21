using Domain.Entities.SPB;

namespace Domain.Services.Interfaces
{
    public interface ISpbService
    {
        Task ProcessEventReceived(SpbEvent spbEvent);
    }
}
