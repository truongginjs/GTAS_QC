using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get() => "test";

        [Authorize]
        [HttpGet]
        public string Secret() => "secret";
    }
}