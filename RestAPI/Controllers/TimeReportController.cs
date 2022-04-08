﻿using Microsoft.AspNetCore.Http;
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
    public class TimeReportController : ControllerBase
    {
        private ITimeRepRepository<TimeReport> _timeRepRepo;

        public TimeReportController(ITimeRepRepository<TimeReport> timeRepRepo)
        {
            _timeRepRepo = timeRepRepo;
        }
        public async Task<IActionResult> GetAllTimeReports()
        {
            return Ok(await _timeRepRepo.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TimeReport>> GetOneTimeReport(int id)
        {
            try
            {
                var result = await _timeRepRepo.GetSingle(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get data from database...");
            }

        }

        [HttpPost]
        public async Task<ActionResult<TimeReport>> AddNewTimeReport(TimeReport newTimeReport)
        {
            try
            {
                if (newTimeReport == null)
                {
                    return BadRequest("TimeReport was not added");
                }
                var createdTimeRep = await _timeRepRepo.Add(newTimeReport);
                return CreatedAtAction(nameof(GetOneTimeReport), new { id = createdTimeRep.TimeReportId }, createdTimeRep);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error To Add TimeReport");
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<TimeReport>> UpdateTimeReport(int id, TimeReport timeReport)
        {
            try
            {
                if (id != timeReport.TimeReportId)
                {
                    return BadRequest("Time report with given ID was not found");
                }
                var timeRepToUpdate = await _timeRepRepo.GetSingle(id);
                if (timeRepToUpdate == null)
                {
                    return NotFound($"Time report with ID: {id} was not found");
                }
                return await _timeRepRepo.Update(timeReport);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to update time report");
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TimeReport>> DeleteTimeReport(int id)
        {
            try
            {
                var timeRepToDelete = await _timeRepRepo.GetSingle(id);
                if (timeRepToDelete == null)
                {
                    return NotFound($"Time report with ID; {id} was not found...");
                }
                return await _timeRepRepo.Delete(id);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error occured trying to delete time report");
            }
        }
        [HttpGet]
        [Route("MembersOfProject/{id}")]
        public async Task<ActionResult<TimeReport>> EmpsOfProjectId(int id)
        {
            try
            {
                var result = await _timeRepRepo.GetTimeReportsByEmpId(id);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound($"No interests were found of that person");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to get persons interests");
            }
        }
    }
}
