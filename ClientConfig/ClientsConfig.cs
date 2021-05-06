using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialFit.ClientConfig
{
    public class ClientsConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.isActive)
                   .HasDefaultValue(true)
                   .IsRequired();

            builder.Property(c => c.Name)
                   .IsRequired(false)
                   .HasDefaultValue("");

            builder.Property(c => c.genre)
                   .IsRequired(false);

            builder.Property(c => c.Login)
                   .IsRequired()
                   .HasMaxLength(45);

            builder.Property(c => c.Password)
                   .HasMaxLength(800)
                   .IsRequired();

            builder.Property(c => c.CreatedAt)
                   .HasDefaultValueSql("getdate()");
         
        }
    }

}
