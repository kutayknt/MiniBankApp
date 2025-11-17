using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniBankApp.Entities;

namespace MiniBankApp.EntityConfiguration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //RelationShip Yapılandırması
            builder.HasMany(u => u.BankAccounts)
                .WithOne(ba => ba.User).HasForeignKey(ba => ba.UserId);
            //Property Yapılandırmaları
            builder.Property(u => u.Name);
                
        }
    }
}
