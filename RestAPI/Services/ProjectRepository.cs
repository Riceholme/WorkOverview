using RestAPI.Model;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Services
{
    public class ProjectRepository : IProjRepository<Project>
    {
        private Context _projContext;
        public ProjectRepository(Context projContext)
        {
            _projContext = projContext;
        }

        public Task<Project> Add(Project newEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Project> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetEmployeesOfProjectId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Project> Update(Project Entity)
        {
            throw new NotImplementedException();
        }
    }
}
