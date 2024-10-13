﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tareaPweb.Data;

#nullable disable

namespace tareaPweb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241013011754_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("tareaPweb.models.Personaje", b =>
                {
                    b.Property<int>("PersonajeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ArmaFavorita")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HabilidadEspecial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagenPersonaje")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NivelPoder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("PersonajeId");

                    b.ToTable("Personajes");
                });

            modelBuilder.Entity("tareaPweb.models.Plataforma", b =>
                {
                    b.Property<int>("PlataformaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlataformaId");

                    b.ToTable("Plataformas");
                });

            modelBuilder.Entity("tareaPweb.models.VideoJuegos", b =>
                {
                    b.Property<int>("VideoJuegoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desarrollador")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaLanzamiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagenPortada")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PlataformaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("VideoJuegoId");

                    b.HasIndex("PlataformaId");

                    b.ToTable("Videojuegos");
                });

            modelBuilder.Entity("tareaPweb.models.VideoJuegos", b =>
                {
                    b.HasOne("tareaPweb.models.Plataforma", "Plataforma")
                        .WithMany()
                        .HasForeignKey("PlataformaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plataforma");
                });
#pragma warning restore 612, 618
        }
    }
}
