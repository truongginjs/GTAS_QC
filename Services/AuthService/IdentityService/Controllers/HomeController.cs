using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController: ControllerBase
    {
        [HttpGet]
        public string Test() => "Test";
    }
}
