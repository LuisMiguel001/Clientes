﻿// <auto-generated />
using System;
using Clientes.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clientes.Migrations.Tickets
{
    [DbContext(typeof(TicketsContext))]
    partial class TicketsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Clientes.Models.Sistemas", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Asunto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("PrioridadId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SistemaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SolicitadoPor")
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId");

                    b.ToTable("Sistemas");
                });
#pragma warning restore 612, 618
        }
    }
}
