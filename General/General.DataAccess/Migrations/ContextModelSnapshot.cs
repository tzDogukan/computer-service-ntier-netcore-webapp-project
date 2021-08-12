﻿// <auto-generated />
using General.DataAccess.Concrete.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace General.DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("General.Entities.CompanyService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ControlCenterId")
                        .HasColumnType("int");

                    b.Property<string>("icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("longexplanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortexplanation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ControlCenterId");

                    b.ToTable("CompanyService");
                });

            modelBuilder.Entity("General.Entities.ControlCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControlcenterKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contract1tr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contract2tr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contract3tr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contract4tr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mainsliderimage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mainsliderimage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mainsliderimage3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mainsliderimage4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parallax1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parallax2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parallax3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socialnetwork1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socialnetwork2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socialnetwork3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socialnetwork4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("webadress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ControlCenters");
                });

            modelBuilder.Entity("General.Entities.CompanyService", b =>
                {
                    b.HasOne("General.Entities.ControlCenter", "ControlCenter")
                        .WithMany("CompanyServices")
                        .HasForeignKey("ControlCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
