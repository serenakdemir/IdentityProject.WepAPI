﻿using IdentityProject.WepAPI.Models.Dtos.Users.Request;
using IdentityProject.WepAPI.Models.Dtos.Users.Response;
using IdentityProject.WepAPI.Models;
using IdentityProject.WepAPI.Repository.Abstracts;
using IdentityProject.WepAPI.Services.Abstracts;

namespace IdentityProject.WepAPI.Services.Concretes;

public class UserService : IUserService
{
    private IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User Add(AddUserRequestDto dto)
    {
        User user = (User)dto;

        User created = _userRepository.Add(user);

        return created;
    }

    public User Delete(int id)
    {
        User user = _userRepository.Delete(id);
        return user;
    }

    public List<UserResponseDto> GetAllUsers()
    {
        return _userRepository.GetAll().Select(x => (UserResponseDto)x).ToList();
    }

    public User GetByEmail(string email)
    {
        User user = _userRepository.GetByEmail(email);
        return user;
    }

    public User GetById(int id)
    {
        User user = _userRepository.GetById(id);
        return user;
    }

    public User Update(User user)
    {
        User updated = _userRepository.Update(user);
        return updated;
    }
}
