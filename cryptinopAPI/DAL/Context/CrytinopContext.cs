using System;
using cryptinopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace cryptinopAPI.DAL.Context
{
    public class CryptinopContext : DbContext
    {
        public CryptinopContext(DbContextOptions<CryptinopContext> options)
        : base(options)
        {
        }

        public DbSet<Monnaie> Monnaies { get; set; }
    
    }
}
