﻿// <auto-generated />
using Hair_Dressing_Appointments_Core_Web_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hair_Dressing_Appointments_Core_Web_App.Migrations
{
    [DbContext(typeof(Hair_Dressing_Appointments_DataContext))]
    [Migration("20200107232343_HairDressing")]
    partial class HairDressing
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("HairDresserId")
                        .HasColumnType("int");

                    b.Property<int>("HairDressingOptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("HairDresserId");

                    b.HasIndex("HairDressingOptionId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MobilePhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.HairDresser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsPermanent")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HairDresser");
                });

            modelBuilder.Entity("Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.HairDressingOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OptionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HairDressingOption");
                });

            modelBuilder.Entity("Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.Appointment", b =>
                {
                    b.HasOne("Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.HairDresser", "HairDresser")
                        .WithMany()
                        .HasForeignKey("HairDresserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hair_Dressing_Appointments_Core_Web_App.BusinessLayer.HairDressingOption", "HairDressingOption")
                        .WithMany()
                        .HasForeignKey("HairDressingOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}