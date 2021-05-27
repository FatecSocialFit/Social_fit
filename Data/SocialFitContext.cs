using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialFit.ClientConfig;
using SocialFit.Models;

namespace SocialFit.Data
{
    public class SocialFitContext : DbContext
    {
        public SocialFitContext (DbContextOptions<SocialFitContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modeBuilder)
        {
            modeBuilder.ApplyConfiguration(new ClientsConfig());

            base.OnModelCreating(modeBuilder);
        }
        public DbSet<SocialFit.Models.Client> Client { get; set; }
        public DbSet<SocialFit.Models.Company> Companies { get; set; }
       

    }
}
