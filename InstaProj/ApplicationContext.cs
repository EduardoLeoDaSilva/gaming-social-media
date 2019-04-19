﻿using InstaProj.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaProj
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<Feed> Feeds { get; set; }
        public DbSet<Noticias> Noticias { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(u => u.UsuarioId);
            modelBuilder.Entity<Usuario>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Postagem>().HasKey(p => p.PostagemId);
            modelBuilder.Entity<Postagem>().HasOne(p => p.Usuario).WithMany(u => u.Postagens);
            modelBuilder.Entity<Usuario>().HasMany(u => u.Postagens).WithOne(p => p.Usuario);
            modelBuilder.Entity<Feed>().HasKey(f => f.FeedId);
            modelBuilder.Entity<Feed>().HasMany(f => f.Postagens).WithOne(p => p.Feed).IsRequired();
        }

    }
}
