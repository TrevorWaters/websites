using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCertPortal.Shared;

namespace TaxCertPortal.Shared
{
    public class TaxCertPortalContext : DbContext
    {
        public virtual DbSet<TaxCertificate> TaxCertificates { get; set; }
        public TaxCertPortalContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source = ../../../../Db/TaxCertPortal.db;");
            }
               
        }
    }


}
