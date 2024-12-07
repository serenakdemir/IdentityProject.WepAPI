using IdentityProject.WepAPI.Models.Dtos.Users.Request;
using IdentityProject.WepAPI.Models.Dtos.Users.Response;
using IdentityProject.WepAPI.Models;

namespace IdentityProject.WepAPI.Services.Abstracts;

public interface IUserService
{
    List<UserResponseDto> GetAllUsers();
    User GetById(int id);
    User Add(AddUserRequestDto dto);
    User Update(User user);
    User GetByEmail(string email);
    User Delete(int id);
}
