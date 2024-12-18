//------------------------------------------------------------------------------

// <auto-generated>

//     This code was generated from a template.

//

//     Manual changes to this file may cause unexpected behavior in your application.

//     Manual changes to this file will be overwritten if the code is regenerated.

// </auto-generated>

//------------------------------------------------------------------------------

using Domain.Entity;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;


using System;

using System.Collections.Generic;

namespace Presistence.Entities

{



    

    public class ConfigTBLConfiguration : IEntityTypeConfiguration<ConfigTBL>

    {

        public void Configure(EntityTypeBuilder<ConfigTBL> builder)

        {

            builder.ToTable("ConfigTBL", "GeneralInfo");

            builder.HasKey(x => x.ID);

            builder.Property(e => e.Explain).IsRequired(false).HasMaxLength(3000);
            builder.Property(e=>e.DateInsert).HasDefaultValueSql("CONVERT(varchar, SYSDATETIME(), 121)");
            builder.Property(e=>e.Status).HasDefaultValue(100);
            builder.Property(e=>e.Type).HasDefaultValue(1);
             


            //builder.HasOne(e => e.StateTBL).WithMany(c => c.ConfigTBLs)
            //.HasForeignKey(x=>x.StateTBLID).OnDelete(DeleteBehavior.Restrict);
        }

    }

}
