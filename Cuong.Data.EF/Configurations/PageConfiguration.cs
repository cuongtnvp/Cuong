using Cuong.Data.EF.Extensions;
using Cuong.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cuong.Data.EF.Configurations
{
    public class PageConfiguration : DbEntityConfiguration<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}
