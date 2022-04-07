using RestAPI.Model;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestAPI.Services
{
    public class ProjectRepository : IProjRepository<Project>
    {
        private Context _projContext;
        public ProjectRepository(Context projContext)
        {
            _projContext = projContext;
        }

        public async Task<Project> Add(Project newProject)
        {
            var result = await _projContext.Projects
                .AddAsync(newProject);
            await _projContext
                .SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Project> Delete(int id)
        {
            var result = await _projContext.Projects
                .FirstOrDefaultAsync(p => p.ProjectId == id);
            if (result != null)
            {
                _projContext.Projects
                    .Remove(result);
                await _projContext
                    .SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _projContext.Projects
                .ToListAsync();
        }

        public Task<IEnumerable<Project>> GetEmployeesOfProjectId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Project> GetSingle(int id)
        {
            return await _projContext.Projects
                .FirstOrDefaultAsync(p => p.ProjectId == id);
        }

        public async Task<Project> Update(Project project)
        {
            var result = await _projContext.Projects
                .FirstOrDefaultAsync(p => p.ProjectId == project.ProjectId);
            if (result != null)
            {
                result.ProjectName = project.ProjectName;
                return result;
            }
            return null;
        }
    }
}
