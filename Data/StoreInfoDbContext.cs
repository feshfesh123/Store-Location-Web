using Microsoft.EntityFrameworkCore;
using StoreInfo.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreInfo.Data
{
    public class StoreInfoDbContext : DbContext
    {
        public StoreInfoDbContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<Store> Stores { get; set; }
    }
}
