using IdentityProject.WepAPI.Models.Dtos.Users.Request;
using IdentityProject.WepAPI.Services.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.WepAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private IUserService _userService;
    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _userService.GetAllUsers();
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add(AddUserRequestDto user)
    {
        var result = _userService.Add(user);
        return Ok(result);
    }

    [HttpGet("getemail")]
    public IActionResult GetByEmail(string email)
    {



        var result = _userService.GetByEmail(email);
        return Ok(result);
    }
}
