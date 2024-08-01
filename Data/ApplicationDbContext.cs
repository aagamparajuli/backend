using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using wandermate_backend.Models;

namespace wandermate_backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet <Hotel> Hotel { get; set; } 
        public DbSet <TravelPackage> TravelPackage { get; set; } 
    }
}