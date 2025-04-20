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
    public class BulletinConfig : IEntityTypeConfiguration<BulletinSoin>
    {
        public void Configure(EntityTypeBuilder<BulletinSoin> builder)
        {
            builder.HasOne(f => f.Patient).WithMany(p => p.BulletinSoins)
               .HasForeignKey(f => f.PatientFk);
        }
    }
}
