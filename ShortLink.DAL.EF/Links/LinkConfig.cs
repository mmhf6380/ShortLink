using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShortLink.Core.Entities.Links;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.DAL.EF.Links
{
    public class LinkConfig : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.ShortText).IsRequired();

        }
    }
}
