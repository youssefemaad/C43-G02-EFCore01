using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignement_1.DdContext
{
    internal class ItiDbContext : DbContext
    {
        public ItiDbContext(): base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= .; Database = iti; Trusted_Connection = true");
        }
    }

}