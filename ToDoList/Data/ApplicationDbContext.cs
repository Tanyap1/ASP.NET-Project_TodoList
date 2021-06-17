using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //application db content 
        public DbSet<List> Lists { get; set; }
        public DbSet<TaskCategory> TaskCategories { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Detail> Details { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
