﻿// <auto-generated />

using System;
using JTracker.jtcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JTracker.Migrations
{
    [DbContext(typeof(JTContext))]
    [Migration("20190118164320_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("mysqlefcore.Log", b =>
                {
                    b.Property<long>("LogId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DispositionDate");

                    b.Property<short>("Dispositioned");

                    b.Property<DateTime>("Generated");

                    b.Property<short>("LogLevel");

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
