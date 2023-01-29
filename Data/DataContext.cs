using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCollection.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiCollection.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}