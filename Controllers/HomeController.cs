using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceTest.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class HomeController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Get()
        {
            return Redirect("/swagger");
        }
        [Route("/Test")]
        public IActionResult Home()
        {
            return Content("Hello World1321321");
        }
    }



}