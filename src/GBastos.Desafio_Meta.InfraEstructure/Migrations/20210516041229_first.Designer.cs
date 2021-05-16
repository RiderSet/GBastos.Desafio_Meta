﻿// <auto-generated />
using System;
using GBastos.Desafio_Meta.InfraEstructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GBastos.Desafio_Meta.InfraEstructure.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210516041229_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GBastos.Desafio_Meta.ApplicationCore.Audiencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtHrAudiencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmisAudiencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PtsAudiencia")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Audiencia");
                });

            modelBuilder.Entity("GBastos.Desafio_Meta.ApplicationCore.Emissora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Emissora");
                });
#pragma warning restore 612, 618
        }
    }
}