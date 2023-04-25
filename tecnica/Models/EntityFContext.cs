using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace tecnica.Models
{
    public partial class EntityFContext : DbContext
    {
        public EntityFContext()
        {
        }

        public EntityFContext(DbContextOptions<EntityFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ALogin> ALogin { get; set; }
        public virtual DbSet<Clases> Clases { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Matriculas> Matriculas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DVRD5GT\\SQLEXPRESS01; DataBase=EntityF;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALogin>(entity =>
            {
                entity.ToTable("A_login");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contra)
                    .HasColumnName("contra")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            });

            modelBuilder.Entity<Clases>(entity =>
            {
                entity.ToTable("clases");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.ToTable("estudiante");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApellidoM)
                    .HasColumnName("apellidoM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoP)
                    .HasColumnName("apellidoP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasColumnName("nombres")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Matriculas>(entity =>
            {
                entity.ToTable("matriculas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdClase).HasColumnName("id_clase");

                entity.Property(e => e.IdEstudiante).HasColumnName("id_estudiante");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PK__Usuarios__080A9743BAE4B054");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoIdentidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FNacimiento)
                    .HasColumnName("f_nacimiento")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
