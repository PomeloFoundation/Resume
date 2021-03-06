﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using YuukoResume.Models;

namespace YuukoResume.Migrations
{
    [DbContext(typeof(ResumeContext))]
    partial class ResumeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-preview1-22509");

            modelBuilder.Entity("Pomelo.AspNetCore.Extensions.BlobStorage.Models.Blob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Bytes");

                    b.Property<long>("ContentLength");

                    b.Property<string>("ContentType")
                        .HasMaxLength(128);

                    b.Property<string>("FileName")
                        .HasMaxLength(128);

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("FileName");

                    b.HasIndex("Time");

                    b.ToTable("Blobs");
                });

            modelBuilder.Entity("YuukoResume.Models.Certificate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BlobId");

                    b.Property<long>("PRI");

                    b.Property<string>("Title")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("BlobId");

                    b.HasIndex("PRI");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("YuukoResume.Models.Education", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("From");

                    b.Property<string>("Profession");

                    b.Property<string>("School")
                        .HasMaxLength(512);

                    b.Property<DateTime?>("To");

                    b.HasKey("Id");

                    b.HasIndex("From");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("YuukoResume.Models.Experience", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company")
                        .HasMaxLength(512);

                    b.Property<string>("Description");

                    b.Property<DateTime>("From");

                    b.Property<string>("Position")
                        .HasMaxLength(512);

                    b.Property<DateTime?>("To");

                    b.HasKey("Id");

                    b.HasIndex("From");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("YuukoResume.Models.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<bool>("IsRead");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("IsRead");

                    b.HasIndex("Time");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("YuukoResume.Models.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Catalog")
                        .HasMaxLength(1024);

                    b.Property<string>("DemoUrl")
                        .HasMaxLength(256);

                    b.Property<string>("Description");

                    b.Property<DateTime>("From");

                    b.Property<string>("GitHub")
                        .HasMaxLength(256);

                    b.Property<string>("Tags")
                        .HasMaxLength(1024);

                    b.Property<string>("Title")
                        .HasMaxLength(1024);

                    b.Property<DateTime?>("To");

                    b.HasKey("Id");

                    b.HasIndex("From");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("YuukoResume.Models.Skill", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Level");

                    b.Property<int>("Performance");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("Level");

                    b.HasIndex("Performance");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("YuukoResume.Models.Certificate", b =>
                {
                    b.HasOne("Pomelo.AspNetCore.Extensions.BlobStorage.Models.Blob", "Blob")
                        .WithMany()
                        .HasForeignKey("BlobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
