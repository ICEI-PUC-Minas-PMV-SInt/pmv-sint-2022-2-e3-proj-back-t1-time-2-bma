﻿using Microsoft.EntityFrameworkCore;

namespace cadastro_beneficiario.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}