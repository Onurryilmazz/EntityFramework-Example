using System;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=server;DataBase=EfProject;Trusted_Connection=false;User Id=SA; Password=password;TrustServerCertificate=true");
        }

        public DbSet<User> Users { get; set; }
    }
}

