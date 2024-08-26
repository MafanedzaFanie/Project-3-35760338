using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Linq;
using System.Collections.Generic;
using System.Collections;


namespace TelemetryPortal_MVC.Repository
{
    public class ProjectRepository
    {
      
        protected readonly TechtrendsContext _context = new TechtrendsContext();
        public IEnumerable<Project> GetAll()
        {
            return _context.Projects.ToList();
        }
    }
}
