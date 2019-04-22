﻿// <auto-generated />
using System;
using InstaProj;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InstaProj.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190419222238_MudandoPropriedadeTituloNoticas")]
    partial class MudandoPropriedadeTituloNoticas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InstaProj.Models.Entidades.Feed", b =>
                {
                    b.Property<int>("FeedId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("FeedId");

                    b.ToTable("Feeds");
                });

            modelBuilder.Entity("InstaProj.Models.Entidades.Noticias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Titulo")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("texto");

                    b.HasKey("Id");

                    b.ToTable("Noticias");
                });

            modelBuilder.Entity("InstaProj.Models.Entidades.Postagem", b =>
                {
                    b.Property<int>("PostagemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FeedId")
                        .IsRequired();

                    b.Property<byte[]>("Imagem");

                    b.Property<string>("Texto");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("PostagemId");

                    b.HasIndex("FeedId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Postagens");
                });

            modelBuilder.Entity("InstaProj.Models.Entidades.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<string>("Sexo");

                    b.Property<byte[]>("foto");

                    b.HasKey("UsuarioId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("InstaProj.Models.Entidades.Postagem", b =>
                {
                    b.HasOne("InstaProj.Models.Entidades.Feed", "Feed")
                        .WithMany("Postagens")
                        .HasForeignKey("FeedId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InstaProj.Models.Entidades.Usuario", "Usuario")
                        .WithMany("Postagens")
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
