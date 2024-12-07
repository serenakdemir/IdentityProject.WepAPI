using IdentityProject.WepAPI.Models;

namespace IdentityProject.WepAPI.Repository.Abstracts;

public interface IUserRepository : IEntityRepository<User>
{
    User GetByEmail(string email);
    List<User> GetAllByUsernameContains(string text);
}
