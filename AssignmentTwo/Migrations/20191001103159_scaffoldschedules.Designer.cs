﻿// <auto-generated />
using System;
using AssignmentTwo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssignmentTwo.Migrations
{
    [DbContext(typeof(AssignmentTwoContext))]
    [Migration("20191001103159_scaffoldschedules")]
    partial class scaffoldschedules
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssignmentTwo.Models.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography");

                    b.Property<string>("Email");

                    b.Property<string>("PhotoUrl")
                        .HasColumnName("PhotoURL");

                    b.HasKey("Id");

                    b.ToTable("Coach");
                });

            modelBuilder.Entity("AssignmentTwo.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoachEmail");

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<DateTime>("When");

                    b.HasKey("Id");

                    b.ToTable("Schedule");
                });
#pragma warning restore 612, 618
        }
    }
}
