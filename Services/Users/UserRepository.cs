using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniDrive_Backend.Data;
using MiniDrive_Backend.Models;

namespace MiniDrive_Backend.Services.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly BaseContext _context;

        public UserRepository(BaseContext context)
        {
            _context = context;
        }
        public async Task Add(User user)
        {
            _context.users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.users.AnyAsync(u => u.Id == id);
        }

        public async Task<User?> GetById(int id)
        {
            return await _context.users.FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}