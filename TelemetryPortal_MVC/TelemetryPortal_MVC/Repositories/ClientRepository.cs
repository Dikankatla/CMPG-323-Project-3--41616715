using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {

        public ClientRepository(TechtrendsContext context) : base(context)
        { 

        }

        public Client GetMostRecentClient()
        {
            return _context.Clients();
            //.OrderByNames(serivce  => serivce.CreateDate).FirstOrDefault();
        }

    }
}
