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
    public class TimeReportController : ControllerBase
    {
        private ITimeRepRepository<TimeReport> _timeRepRepo;

        public TimeReportController(ITimeRepRepository<TimeReport> timeRepRepo)
        {
            _timeRepRepo = timeRepRepo;
        }
    }
}
