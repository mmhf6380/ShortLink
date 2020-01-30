using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShortLink.Core.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.DAL.EF.Persons
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.FullName).IsRequired();

        }
    }
}
