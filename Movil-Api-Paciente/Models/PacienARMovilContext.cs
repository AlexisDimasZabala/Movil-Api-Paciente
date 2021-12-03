using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Movil_Api_Paciente.Models
{
    public partial class PacienARMovilContext : DbContext
    {
        public PacienARMovilContext()
        {
        }

        public PacienARMovilContext(DbContextOptions<PacienARMovilContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<UsuarioDcotor> UsuarioDcotors { get; set; }
        public virtual DbSet<UsuarioDoctor> UsuarioDoctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=PacienAR-Movil;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.IdDoctor);

                entity.ToTable("Doctor");

                entity.Property(e => e.IdDoctor).HasColumnName("id_doctor");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Contra)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("contra");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("especialidad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente);

                entity.ToTable("Paciente");

                entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Alcohol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("alcohol");

                entity.Property(e => e.Alergias)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("alergias");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("documento");

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("domicilio");

                entity.Property(e => e.Drogas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("drogas");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.GrupoSanguineo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("grupoSanguineo");

                entity.Property(e => e.Infusiones)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("infusiones");

                entity.Property(e => e.Neurologico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("neurologico");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Quirurgico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quirurgico");

                entity.Property(e => e.Rating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rating");

                entity.Property(e => e.Respiratorio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("respiratorio");

                entity.Property(e => e.Riesgo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("riesgo");

                entity.Property(e => e.Tabaco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tabaco");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.VacCovid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vacCovid");
            });

            modelBuilder.Entity<UsuarioDcotor>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioDoctor);

                entity.ToTable("Usuario_dcotor");

                entity.Property(e => e.IdUsuarioDoctor).HasColumnName("id_usuarioDoctor");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<UsuarioDoctor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UsuarioDoctor");

                entity.Property(e => e.Contra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contra");

                entity.Property(e => e.IdDoctor).HasColumnName("id_doctor");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
