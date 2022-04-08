using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using RestAPI.Services;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjRepository<Project> _projRepo;

        public ProjectController(IProjRepository<Project> projRepo)
        {
            _projRepo = projRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProjects()
        {
            return Ok(await _projRepo.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Project>> GetOneProject(int id)
        {
            try
            {
                var result = await _projRepo.GetSingle(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, " Error to get Data from Database....");
            }

        }


        [HttpPost]
        public async Task<ActionResult<Project>> AddNewProject(Project newProject)
        {
            try
            {
                if (newProject == null)
                {
                    return BadRequest("Employee was not added");
                }
                var createdProject = await _projRepo.Add(newProject);
                return CreatedAtAction(nameof(GetOneProject), new { id = createdProject.ProjectId }, createdProject);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error To Add Project");
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Project>> UpdateProject(int id, Project project)
        {
            try
            {
                if (id != project.ProjectId)
                {
                    return BadRequest("Project with given ID was not found");
                }
                var projectToUpdate = await _projRepo.GetSingle(id);
                if (projectToUpdate == null)
                {
                    return NotFound($"Project with ID: {id} was not found");
                }
                return await _projRepo.Update(project);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to update project");
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Project>> DeleteProject(int id)
        {
            try
            {
                var projectToDelete = await _projRepo.GetSingle(id);
                if (projectToDelete == null)
                {
                    return NotFound($"Project with ID; {id} was not found...");
                }
                return await _projRepo.Delete(id);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error occured trying to delete Project");
            }
        }
    }
}
