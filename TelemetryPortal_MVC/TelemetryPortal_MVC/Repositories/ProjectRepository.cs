using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositories
{
    public class ProjectRepository
    {
        protected readonly TechtrendsContext _context = new TechtrendsContext();

        public  IEnumerable<Project> GetAll()
        {
            return _context.Projects.ToList();
        }

    }
}
