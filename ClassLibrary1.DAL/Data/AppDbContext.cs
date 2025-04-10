using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace ConsoleApp1.DAL.Data
{
    public class AppDbContext : DbContext
    {
        //private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UA;Integrated Security=True;Connect Timeout=30;";

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();


            var _connectionString = connection.GetConnectionString("DefualtConection");

            optionsBuilder.UseSqlServer(_connectionString);

        }
    }
}