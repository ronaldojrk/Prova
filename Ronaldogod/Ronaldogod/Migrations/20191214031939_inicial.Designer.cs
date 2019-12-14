﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ronaldogod.Models;

namespace Ronaldogod.Migrations
{
    [DbContext(typeof(RonaldogodContext))]
    [Migration("20191214031939_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ronaldogod.Models.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idade");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("nascionalidade")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("Ronaldogod.Models.Placar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dia");

                    b.Property<int>("JogadorId");

                    b.Property<int>("TotalPontos");

                    b.HasKey("Id");

                    b.HasIndex("JogadorId");

                    b.ToTable("Placar");
                });

            modelBuilder.Entity("Ronaldogod.Models.Placar", b =>
                {
                    b.HasOne("Ronaldogod.Models.Jogador", "Jogador")
                        .WithMany()
                        .HasForeignKey("JogadorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}