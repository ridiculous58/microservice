using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appointment.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Appointment.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public IActionResult Get()
        {

            return Ok();
        }
    }
}
