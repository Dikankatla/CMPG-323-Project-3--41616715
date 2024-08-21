using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Client GetMostRecentClient();
    }
}
