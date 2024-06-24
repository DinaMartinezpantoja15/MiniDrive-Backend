using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniDrive_Backend.Models;

namespace MiniDrive_Backend.Services.Users
{
    public interface IUserRepository
    {
        Task<User?> GetById(int id);
        Task Add(User user);
        Task<bool> CheckExistence(int id);
    }
}