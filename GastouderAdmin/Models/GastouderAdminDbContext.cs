using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GastouderAdmin.Models
{
    public class GastouderAdminDbContext : DbContext
    {
        public DbSet<Gastouder> Gastouders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                    Initial Catalog=GastouderAdmin;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                    TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}