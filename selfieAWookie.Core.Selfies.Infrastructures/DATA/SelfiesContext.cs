using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using selfieAWookie.Core.Selfies.Domain;
using selfieAWookie.Core.Selfies.Infrastructures.DATA.TypeConfiguration;
using Microsoft.Extensions.Configuration;

namespace selfieAWookie.Core.Selfies.Infrastructures
{
    public class SelfiesContext : DbContext
    {
        #region constructors

        public SelfiesContext(DbContextOptions options) : base(options)
        {
          
        }
        public SelfiesContext():base() { }
        #endregion
        #region internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SelfieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WookieEntityTypeConfiguration());

        }
        #endregion
        #region properties
        public DbSet<Selfie> selfies { get; set; }
        public DbSet<Wookie> Wookies { get; set; }
        #endregion

    }
    
}
