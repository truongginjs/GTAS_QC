using AutoMapper;
using IdentityService.DTOs.Requests;
using IdentityService.DTOs.Responses;
using IdentityService.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthController: ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;

        public AuthController(IAuthService authService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<UserResDTO>> Login([FromBody] UserLoginReqDTO user)
        {
            var data = _authService.Login(user, out string message);
            var result = await  Task.FromResult(data);
            return Ok(result);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<bool>> Logout()
        {
            var result = await Task.FromResult(true);

            return Ok(result);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<UserResDTO>> RefreshToken([FromBody] RefreshTokenReqDTO user)
        {
            var result = await Task.FromResult(new UserResDTO { });

            return Ok(result);
        }
    }
}
