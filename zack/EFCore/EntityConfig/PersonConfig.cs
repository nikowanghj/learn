using EFCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.EntityConfig
{
    public class PersonConfig:IEntityTypeConfiguration<Person>
    {
      public  void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("T_Persons");
        }
    }
}
