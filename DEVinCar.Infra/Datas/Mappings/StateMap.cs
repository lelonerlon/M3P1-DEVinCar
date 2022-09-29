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
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {


            modelBuilder.Entity<State>(builder =>
            {
                builder.ToTable("States");
                builder.HasKey(s => s.Id);

                builder
                    .Property(s => s.Name)
                    .HasMaxLength(100)
                    .IsRequired();

                builder
                    .Property(s => s.Initials)
                    .HasMaxLength(2)
                    .IsRequired();

                builder
                    .HasData(new[] {
                    new State (1, "Acre", "AC"),
                    new State (2, "Alagoas", "AL"),
                    new State (3, "Amap�", "AP"),
                    new State (4, "Amazonas", "AM"),
                    new State (5, "Bahia", "BA"),
                    new State (6, "Cear�", "CE"),
                    new State (7, "Distrito Federal", "DF"),
                    new State (8, "Esp�rito Santo", "ES"),
                    new State (9, "Goi�s", "GO"),
                    new State (10, "Maranh�o", "MA"),
                    new State (11, "Mato Grosso", "MT"),
                    new State (12, "Mato Grosso do Sul", "MS"),
                    new State (13, "Minas Gerais", "MG"),
                    new State (14, "Par�", "PA"),
                    new State (15, "Para�ba", "PB"),
                    new State (16, "Paran�", "PR"),
                    new State (17, "Pernambuco", "PE"),
                    new State (18, "Piau�", "PI"),
                    new State (19, "Rio de Janeiro", "RJ"),
                    new State (20, "Rio Grande do Norte", "RN"),
                    new State (21, "Rio Grande do Sul", "RS"),
                    new State (22, "Rond�nia", "RO"),
                    new State (23, "Roraima", "RR"),
                    new State (24, "Santa Catarina", "SC"),
                    new State (25, "S�o Paulo", "SP"),
                    new State (26, "Sergipe", "SE"),
                    new State (27, "Tocantins", "TO")
             });
            });
        }
    }
}
       
