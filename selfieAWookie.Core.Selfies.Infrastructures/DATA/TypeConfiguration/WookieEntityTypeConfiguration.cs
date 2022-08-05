using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using selfieAWookie.Core.Selfies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfieAWookie.Core.Selfies.Infrastructures.DATA.TypeConfiguration
{
    internal class WookieEntityTypeConfiguration : IEntityTypeConfiguration<Wookie>
    {
        #region public methods
        public void Configure(EntityTypeBuilder<Wookie> builder)
        {
            builder.ToTable("Wookie");
            builder.HasKey(x => x.id);
           
        }

        
        #endregion
    }
}
