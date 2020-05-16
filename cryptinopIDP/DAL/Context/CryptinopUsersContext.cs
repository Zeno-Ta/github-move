using System;
using cryptinopIDP.Models;
using Microsoft.EntityFrameworkCore;

namespace cryptinopIDP.DAL.Context
{
    public class CryptinopUsersContext : DbContext
    {
        public CryptinopUsersContext(DbContextOptions<CryptinopUsersContext> options)
        : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Adresse> Adresses { get; set; }

        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DbSet<Coordonnee> Coordonnees { get; set; }
    }
}
