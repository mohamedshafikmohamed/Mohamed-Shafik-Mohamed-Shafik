using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Mohamed_Shafik_Mohamed_Shafik.Models
{
    public class DateContext : DbContext
    {
        public DateContext(DbContextOptions<DateContext> options)
            : base(options)
        {
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<My_info>().HasData(
                new My_info
                {
                    Id = 1,
                    Name = "Mohamed Shafik Mohamed",
                    job = "Backend Developer - Asp.net",
                    education= " Pursuing a bachelor ’s degree in computer science at Ain shams university (2017-2021 expected)  GPA : Very Good"


                }


                );
        }
        public DbSet<My_info> info { get; set; }
        public DbSet<Projects> projects { get; set; }

    }
}
