using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TestController : ControllerBase
    {
        [HttpGet("{id}/{a}")]
        public string Index(string id, int a) => "test";
        [HttpGet]
        public string Get() => "test";

        [Authorize]
        [HttpGet]
        public string Secret() => "secret";
    }
}