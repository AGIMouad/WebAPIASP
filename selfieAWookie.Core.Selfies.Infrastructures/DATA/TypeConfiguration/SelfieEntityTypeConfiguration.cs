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
    internal class SelfieEntityTypeConfiguration : IEntityTypeConfiguration<Selfie>
    {
        #region public methods
        public void Configure(EntityTypeBuilder<Selfie> builder)
        {
            builder.ToTable("Selfie");
            builder.HasKey(x => x.Id);
            builder.HasOne(item => item.Wookie).
                WithMany(Item => Item.Selfies);  
           
        }
        #endregion
    }
}
