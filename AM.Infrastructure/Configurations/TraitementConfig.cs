using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class TraitementConfig : IEntityTypeConfiguration<Traitement>
    {
        public void Configure(EntityTypeBuilder<Traitement> builder)
        {
            builder.HasOne(p => p.BulletinSoin).WithMany(p => p.Traitements).HasForeignKey(p => p.BulletinFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.Intervenant).WithMany(p => p.Traitements).HasForeignKey(p => p.IntervenantFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasKey(p => new { p.BulletinFk, p.IntervenantFk, p.DateTraitement });
        }
    }
}
