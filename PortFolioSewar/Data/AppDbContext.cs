using Microsoft.EntityFrameworkCore;
using PortFolioSewar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolioSewar.Data
{
    public class AppDbContext  :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base (options)
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
