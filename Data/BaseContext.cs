using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniDrive_Backend.Models;

namespace MiniDrive_Backend.Data
{
    public class BaseContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }
    }
}