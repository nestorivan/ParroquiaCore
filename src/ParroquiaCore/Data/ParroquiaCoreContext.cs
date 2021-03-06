﻿using Microsoft.EntityFrameworkCore;
using ParroquiaCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParroquiaCore.Data
{
    public class ParroquiaCoreContext : DbContext
    {
        public ParroquiaCoreContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Parroquia> Parroquias { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Colonia> Colonias { get; set; }
        public DbSet<Delegacion> Delegaciones { get; set; }
        public DbSet<CodigoPostal> CodigosPostales { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Archidiocesis> Archidiocesis { get; set; }
        public DbSet<Diocesis> Diocesis { get; set; }
        public DbSet<CleroTitulo> CleroTitulos { get; set; }
        public DbSet<CleroMiembro> CleroMiembros { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<LibroDefuncion> LibroDefunciones { get; set; }
        public DbSet<Defuncion> Defunciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Persona>()
                .HasOne(e => e.Padre);
            modelBuilder.Entity<Persona>()
                .HasOne(e => e.Madre);
            modelBuilder.Entity<Persona>()
                .HasOne(e => e.AbueloPaterno);
            modelBuilder.Entity<Persona>()
                .HasOne(e => e.AbueloMaterno);
            modelBuilder.Entity<Persona>()
                .HasOne(e => e.AbuelaMaterna);
            modelBuilder.Entity<Persona>()
                .HasOne(e => e.AbuelaPaterna);
        }

    }
}
