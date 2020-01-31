namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Domain.Entities;

    public partial class ContextDbEstudiante : DbContext
    {
        public ContextDbEstudiante()
            : base("DefaultConnection")
        {
        }

        public virtual DbSet<Estudiante> Estudiante { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.primer_apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.segundo_apellido)
                .IsUnicode(false);
        }
    }
}
