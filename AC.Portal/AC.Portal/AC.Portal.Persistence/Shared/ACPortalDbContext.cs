using AC.Portal.Domain.Entities;
using AC.Portal.Persistence.Repositories.EsignatureRecipientRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.Portal.Persistence.Shared
{
    public class ACPortalDbContext : DbContext
    {
        public ACPortalDbContext(DbContextOptions<ACPortalDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EsignatureRecipientConfiguration());
        }

        public DbSet<EsignatureRecipient> EsignatureRecipients { get; set; }
        public DbSet<DocuSignEnvelope> DocuSignEnvelopes { get; set; }

    }
}
