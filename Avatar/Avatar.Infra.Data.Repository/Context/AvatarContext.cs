﻿using Avatar.Domain.Entities;
using Avatar.Infra.Data.Repository.Extensions;
using Avatar.Infra.Data.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Avatar.Infra.Data.Repository.Context
{
    public class AvatarContext : DbContext
    {
        public AvatarContext()            
        {

        }

        //For tests
        public AvatarContext(DbContextOptions<AvatarContext> options)
            :base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Skill> Skill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new CompanyMap());            
            modelBuilder.AddConfiguration(new UserMap());         
            modelBuilder.AddConfiguration(new DurationTypeMap());
            modelBuilder.AddConfiguration(new CourseMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Condition used to test configuration
            if (!optionsBuilder.IsConfigured)
            {            
                // get the configuration from the app settings
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                // define the database to use
                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            }
        }
    }
}
