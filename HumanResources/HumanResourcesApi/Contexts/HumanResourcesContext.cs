using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResourcesApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace HumanResourcesApi.Contexts
{
    public class HumanResourcesContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public HumanResourcesContext(DbContextOptions<HumanResourcesContext> options)
            : base(options)
        {
            //  Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasData(
                    new Person()
                    {
                        Id = 1,
                        Name = "New York City",
                        Description = "The one with that big park.",
                        EMail = "test@gmail.com",
                        FirmName = "Microsoft",
                        OpenToWork = true,
                        PhoneNumber = "121321111",
                        Status = "StatusId"
                    });

            modelBuilder.Entity<Skill>()
                .HasData(
                    new Skill()
                    {
                        Id = 1,
                        Name = "C#",
                        Description = "About C#", 
                        PersonId = 1
                    },
                    new Skill()
                    {
                        Id = 2,
                        Name = "Java",
                        Description = "About java",
                        PersonId = 1
                    });

            base.OnModelCreating(modelBuilder);
        }


    }

}
