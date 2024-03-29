﻿// <auto-generated />
using System;
using JTracker.jtcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JTracker.Migrations
{
    [DbContext(typeof(JTContext))]
    partial class JTContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("JTracker.jtcontext.Models.Config", b =>
                {
                    b.Property<long>("ConfigId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("Active");

                    b.Property<string>("DataType")
                        .HasColumnType("text");

                    b.Property<string>("KeyName")
                        .HasColumnType("text");

                    b.Property<string>("KeyValue")
                        .HasColumnType("text");

                    b.HasKey("ConfigId");

                    b.ToTable("Config");
                });

            modelBuilder.Entity("JTracker.jtcontext.Models.Log", b =>
                {
                    b.Property<long>("LogId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DispositionDate");

                    b.Property<byte>("Dispositioned");

                    b.Property<DateTime>("Generated");

                    b.Property<byte>("LogLevel");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("SQL")
                        .HasColumnType("text");

                    b.Property<string>("SourcePage")
                        .HasColumnType("text");

                    b.HasKey("LogId");

                    b.ToTable("Log");
                });
#pragma warning restore 612, 618
        }
    }
}
