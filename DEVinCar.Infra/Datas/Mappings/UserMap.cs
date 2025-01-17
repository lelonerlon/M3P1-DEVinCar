﻿using DEVinCar.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DEVinCar.Infra.Datas.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable ("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email)
                    .HasMaxLength(150)
                    .IsRequired();

            builder.Property(u => u.Password)
                    .HasMaxLength(50)
                    .IsRequired();

            builder.Property(u => u.Name)
                    .HasMaxLength(255)
                    .IsRequired();

            builder.Property(u => u.BirthDate);

            builder.Property(u => u.Role)
                    .IsRequired();


            builder.HasData(new[] {
                    new User (1, "jose@email.com", "123456opp78", "Jose", new DateTime(2000, 12, 10), "Gerente"),
                    new User (2, "andrea@email.com", "987dasd654321", "Andrea", new DateTime(1999, 05, 11), "Vendedor"),
                    new User (3, "adao@email.com", "2589asd", "Adao", new DateTime(2005, 09, 02), "Comprador"),
                    new User (4, "monique@email.com", "asd45uio", "Monique", new DateTime(2001, 06, 07), "Gerente"),
            });
        }
    }
}
