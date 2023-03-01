using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PorraGirona.DataLayer
{
    public partial class PostDbContext : DbContext
    {
        public PostDbContext()
        {
        }

        public PostDbContext(DbContextOptions<PostDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Equips> Equips { get; set; }
        public virtual DbSet<Jugadors> Jugadors { get; set; }
        public virtual DbSet<Partits> Partits { get; set; }
        public virtual DbSet<Penyes> Penyes { get; set; }
        public virtual DbSet<Penyistes> Penyistes { get; set; }
        public virtual DbSet<Porres> Porres { get; set; }
        public virtual DbSet<Puntuacions> Puntuacions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=porragirona;uid=root", x => x.ServerVersion("10.4.25-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equips>(entity =>
            {
                entity.HasKey(e => e.Idequip)
                    .HasName("PRIMARY");

                entity.ToTable("equips");

                entity.Property(e => e.Idequip)
                    .HasColumnName("idequip")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Imatge)
                    .HasColumnName("imatge")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Jugadors>(entity =>
            {
                entity.HasKey(e => e.Idjugador)
                    .HasName("PRIMARY");

                entity.ToTable("jugadors");

                entity.HasIndex(e => e.Idequip)
                    .HasName("idequip");

                entity.Property(e => e.Idjugador)
                    .HasColumnName("idjugador")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idequip)
                    .HasColumnName("idequip")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Temporada)
                    .HasColumnName("temporada")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.HasOne(d => d.IdequipNavigation)
                    .WithMany(p => p.Jugadors)
                    .HasForeignKey(d => d.Idequip)
                    .HasConstraintName("jugadors_ibfk_2");
            });

            modelBuilder.Entity<Partits>(entity =>
            {
                entity.HasKey(e => e.Idpartit)
                    .HasName("PRIMARY");

                entity.ToTable("partits");

                entity.HasIndex(e => e.Idequiplocal)
                    .HasName("idlocal");

                entity.HasIndex(e => e.Idequipvisitant)
                    .HasName("idvisitant");

                entity.Property(e => e.Idpartit)
                    .HasColumnName("idpartit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Datainici)
                    .HasColumnName("datainici")
                    .HasColumnType("datetime");

                entity.Property(e => e.Finalitzat)
                    .HasColumnName("finalitzat")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Golslocal)
                    .HasColumnName("golslocal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Golsvisitant)
                    .HasColumnName("golsvisitant")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idequiplocal)
                    .HasColumnName("idequiplocal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idequipvisitant)
                    .HasColumnName("idequipvisitant")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idsjugadorslocal)
                    .HasColumnName("idsjugadorslocal")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Idsjugadorsvisitant)
                    .HasColumnName("idsjugadorsvisitant")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Jornada)
                    .HasColumnName("jornada")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Temporada)
                    .HasColumnName("temporada")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.HasOne(d => d.IdequiplocalNavigation)
                    .WithMany(p => p.PartitsIdequiplocalNavigation)
                    .HasForeignKey(d => d.Idequiplocal)
                    .HasConstraintName("partits_ibfk_4");

                entity.HasOne(d => d.IdequipvisitantNavigation)
                    .WithMany(p => p.PartitsIdequipvisitantNavigation)
                    .HasForeignKey(d => d.Idequipvisitant)
                    .HasConstraintName("partits_ibfk_5");
            });

            modelBuilder.Entity<Penyes>(entity =>
            {
                entity.HasKey(e => e.Idpenya)
                    .HasName("PRIMARY");

                entity.ToTable("penyes");

                entity.Property(e => e.Idpenya)
                    .HasColumnName("idpenya")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Penyistes>(entity =>
            {
                entity.HasKey(e => e.Idpenyista)
                    .HasName("PRIMARY");

                entity.ToTable("penyistes");

                entity.HasIndex(e => e.Idpenya)
                    .HasName("idpenya");

                entity.Property(e => e.Idpenyista)
                    .HasColumnName("idpenyista")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Cognoms)
                    .HasColumnName("cognoms")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Dataalta)
                    .HasColumnName("dataalta")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idpenya)
                    .HasColumnName("idpenya")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Imatge)
                    .HasColumnName("imatge")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.Nif)
                    .HasColumnName("nif")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Numsoci)
                    .HasColumnName("numsoci")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Rol)
                    .HasColumnName("rol")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.HasOne(d => d.IdpenyaNavigation)
                    .WithMany(p => p.Penyistes)
                    .HasForeignKey(d => d.Idpenya)
                    .HasConstraintName("penyistes_ibfk_2");
            });

            modelBuilder.Entity<Porres>(entity =>
            {
                entity.HasKey(e => e.Idporra)
                    .HasName("PRIMARY");

                entity.ToTable("porres");

                entity.HasIndex(e => e.Idpartit)
                    .HasName("idpartit");

                entity.HasIndex(e => e.Idpenyista)
                    .HasName("idpenyista");

                entity.Property(e => e.Idporra)
                    .HasColumnName("idporra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime");

                entity.Property(e => e.Golslocal)
                    .HasColumnName("golslocal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Golsvisitant)
                    .HasColumnName("golsvisitant")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idpartit)
                    .HasColumnName("idpartit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idpenyista)
                    .HasColumnName("idpenyista")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idsgolejadorslocal)
                    .HasColumnName("idsgolejadorslocal")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Idsgolejadorsvisitant)
                    .HasColumnName("idsgolejadorsvisitant")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.HasOne(d => d.IdpartitNavigation)
                    .WithMany(p => p.Porres)
                    .HasForeignKey(d => d.Idpartit)
                    .HasConstraintName("porres_ibfk_4");

                entity.HasOne(d => d.IdpenyistaNavigation)
                    .WithMany(p => p.Porres)
                    .HasForeignKey(d => d.Idpenyista)
                    .HasConstraintName("porres_ibfk_3");
            });

            modelBuilder.Entity<Puntuacions>(entity =>
            {
                entity.HasKey(e => e.Idpuntuacio)
                    .HasName("PRIMARY");

                entity.ToTable("puntuacions");

                entity.Property(e => e.Idpuntuacio)
                    .HasColumnName("idpuntuacio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idpenyista)
                    .HasColumnName("idpenyista")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Puntuacio)
                    .HasColumnName("puntuacio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Temporada)
                    .HasColumnName("temporada")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
