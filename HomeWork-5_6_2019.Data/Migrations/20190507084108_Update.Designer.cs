﻿// <auto-generated />
using System;
using HomeWork_5_6_2019.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeWork_5_6_2019.Data.Migrations
{
    [DbContext(typeof(CandidateContext))]
    [Migration("20190507084108_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeWork_5_6_2019.Data.Candidate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Confirmed");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("id");

                    b.ToTable("Candidates");
                });
#pragma warning restore 612, 618
        }
    }
}