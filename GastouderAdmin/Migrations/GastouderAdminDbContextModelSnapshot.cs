using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GastouderAdmin.Models;

namespace GastouderAdmin.Migrations
{
    [DbContext(typeof(GastouderAdminDbContext))]
    partial class GastouderAdminDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GastouderAdmin.Models.Consulent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achternaam");

                    b.Property<string>("Voornaam");

                    b.HasKey("Id");

                    b.ToTable("Consulent");
                });

            modelBuilder.Entity("GastouderAdmin.Models.Gastouder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achternaam");

                    b.Property<int?>("ConsulentId");

                    b.Property<bool>("GoPlan");

                    b.Property<string>("Huisnummer");

                    b.Property<bool>("Huisregels");

                    b.Property<bool>("PedBeleid");

                    b.Property<bool>("PedWerkplan");

                    b.Property<string>("Plaats");

                    b.Property<string>("Postcode");

                    b.Property<string>("Starttraject");

                    b.Property<string>("Straat");

                    b.Property<bool>("Tink");

                    b.HasKey("Id");

                    b.HasIndex("ConsulentId");

                    b.ToTable("Gastouders");
                });

            modelBuilder.Entity("GastouderAdmin.Models.Gastouder", b =>
                {
                    b.HasOne("GastouderAdmin.Models.Consulent", "Consulent")
                        .WithMany()
                        .HasForeignKey("ConsulentId");
                });
        }
    }
}
