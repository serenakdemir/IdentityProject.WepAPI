﻿namespace IdentityProject.WepAPI.Models.Dtos.Users.Request;

public class AddUserRequestDto
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }


    public int RoleId { get; set; }
}
