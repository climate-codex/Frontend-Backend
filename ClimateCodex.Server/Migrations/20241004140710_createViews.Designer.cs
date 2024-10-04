﻿// <auto-generated />
using ClimateCodex.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClimateCodex.Server.Migrations
{
    [DbContext(typeof(ClimateCodexDbContext))]
    [Migration("20241004140710_createViews")]
    partial class createViews
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.1.24451.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClimateCodex.Server.Models.ClimateData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("CO2Emissions")
                        .HasColumnType("real");

                    b.Property<float>("MethaneEmissions")
                        .HasColumnType("real");

                    b.Property<float>("PopulationDensity")
                        .HasColumnType("real");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ClimateData");
                });

            modelBuilder.Entity("ClimateCodex.Server.Models.EmissionData", b =>
                {
                    b.Property<int>("EmissionDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmissionDataId"));

                    b.Property<double>("EmissionValue")
                        .HasColumnType("float");

                    b.Property<int>("GHGTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("EmissionDataId");

                    b.HasIndex("GHGTypeId");

                    b.HasIndex("RegionId");

                    b.ToTable("EmissionDatas");
                });

            modelBuilder.Entity("ClimateCodex.Server.Models.GHGType", b =>
                {
                    b.Property<int>("GHGTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GHGTypeId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GasName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GHGTypeId");

                    b.ToTable("GHGTypes");
                });

            modelBuilder.Entity("ClimateCodex.Server.Models.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegionId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("ClimateCodex.Server.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ClimateCodex.Server.Models.EmissionData", b =>
                {
                    b.HasOne("ClimateCodex.Server.Models.GHGType", "GHGType")
                        .WithMany("EmissionData")
                        .HasForeignKey("GHGTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClimateCodex.Server.Models.Region", "Region")
                        .WithMany("EmissionData")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GHGType");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("ClimateCodex.Server.Models.GHGType", b =>
                {
                    b.Navigation("EmissionData");
                });

            modelBuilder.Entity("ClimateCodex.Server.Models.Region", b =>
                {
                    b.Navigation("EmissionData");
                });
#pragma warning restore 612, 618
        }
    }
}
