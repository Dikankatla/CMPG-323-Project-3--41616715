using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        protected new readonly TechtrendsContext _context = new TechtrendsContext();
        public ProjectRepository(TechtrendsContext context) : base(context)
        {
            _context = context;
        }

        public new IEnumerable<Project> GetAll()
        {
            return _context.Projects.ToList();
        }
        

        

    }
}
