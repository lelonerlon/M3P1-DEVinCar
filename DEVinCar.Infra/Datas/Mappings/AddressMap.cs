using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEVinCar.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DEVinCar.Infra.Datas.Mappings
{
	public class AddressMap : IEntityTypeConfiguration<Address>
	{
		public void Configure(EntityTypeBuilder<Address> builder)
		{
			
				builder.ToTable("Address");

				builder.HasKey(d => d.Id);

				builder.Property(d => d.CityId).HasColumnType("int").IsRequired();

				builder.Property(d => d.Street).HasMaxLength(150).IsRequired();

				builder.Property(d => d.Cep).HasMaxLength(8).IsRequired();

				builder.Property(d => d.Number).HasColumnType("int").IsRequired();

				builder.Property(d => d.Complement).HasMaxLength(255);

				builder.HasOne<City>(address => address.City)
					.WithMany(d => d.Addresses)
					.HasForeignKey(address => address.CityId);
			
		}
    }
}