﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FoxManager.Entities;

namespace FoxManager.Migrations
{
    [DbContext(typeof(FoxManagerContext))]
    partial class FoxManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoxManager.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassName");

                    b.Property<string>("Technology");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("FoxManager.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassId");

                    b.Property<string>("Name");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FoxManager.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("PriorityLevel");

                    b.Property<int>("StudentId");

                    b.Property<string>("TaskName");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("FoxManager.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassId");

                    b.Property<string>("TeamName");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });
        }
    }
}
