using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Service.HandleResponses;
using Store.Service.Services.User_Service;
using Store.Service.Services.User_Service.Dtos;

namespace Store.Web.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> Login(LoginDto input)
        {
            var user = await _userService.Login(input);
            if(user is null)
                return BadRequest(new CustomException(400,"Email or Password is incorrect"));
            
            return Ok(user);
        }
    }
}
