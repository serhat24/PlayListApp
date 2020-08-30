using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class PlayListAppContext:DbContext
    {
        
        public PlayListAppContext(DbContextOptions<PlayListAppContext> options):base(options)
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=PlayListApp;user=root;password=");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Musik> Musiks { get; set; }    
        
    }
}
