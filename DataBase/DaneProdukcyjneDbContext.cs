using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebMonitoring.Table.DaneProdukcyjne;

#nullable disable

namespace WebMonitoring.DataBase
{
    public partial class DaneProdukcyjneDbContext : DbContext
    {
        public DaneProdukcyjneDbContext()
        {
        }

        public DaneProdukcyjneDbContext(DbContextOptions<DaneProdukcyjneDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Br10Cela1Dane> Br10Cela1Danes { get; set; }
        public virtual DbSet<Br10Cela2Dane> Br10Cela2Danes { get; set; }
        public virtual DbSet<Br10Cela3Dane> Br10Cela3Danes { get; set; }
        public virtual DbSet<Br10Cela4Dane> Br10Cela4Danes { get; set; }
        public virtual DbSet<Br10Cela5Dane> Br10Cela5Danes { get; set; }
        public virtual DbSet<Hr10Cela0Lp1Dane> Hr10Cela0Lp1Danes { get; set; }
        public virtual DbSet<Hr10Cela1Lp1Dane> Hr10Cela1Lp1Danes { get; set; }
        public virtual DbSet<Hr10Cela1Lp2Dane> Hr10Cela1Lp2Danes { get; set; }
        public virtual DbSet<Hr10Cela2Lp1Dane> Hr10Cela2Lp1Danes { get; set; }
        public virtual DbSet<Hr10Cela2Lp2Dane> Hr10Cela2Lp2Danes { get; set; }
        public virtual DbSet<Hr10Cela3Lp1Dane> Hr10Cela3Lp1Danes { get; set; }
        public virtual DbSet<Hr10Cela3Lp2Dane> Hr10Cela3Lp2Danes { get; set; }
        public virtual DbSet<Hr10Cela3Lp3Dane> Hr10Cela3Lp3Danes { get; set; }
        public virtual DbSet<Hr10Cela4Lp1Dane> Hr10Cela4Lp1Danes { get; set; }
        public virtual DbSet<Hr10Cela4Lp2Dane> Hr10Cela4Lp2Danes { get; set; }
        public virtual DbSet<Hr10Cela4Lp3Dane> Hr10Cela4Lp3Danes { get; set; }
        public virtual DbSet<Hr10Cela5Lp1Dane> Hr10Cela5Lp1Danes { get; set; }
        public virtual DbSet<Hr10Cela5Lp2Dane> Hr10Cela5Lp2Danes { get; set; }
        public virtual DbSet<Hr10Cela5Lp3Dane> Hr10Cela5Lp3Danes { get; set; }
        public virtual DbSet<Hr10CelaGpf1Lp1Dane> Hr10CelaGpf1Lp1Danes { get; set; }
        public virtual DbSet<Hr10CelaGpf2Lp1Dane> Hr10CelaGpf2Lp1Danes { get; set; }
        public virtual DbSet<Hr10CelaGpf3BasicBushingLp1Dane> Hr10CelaGpf3BasicBushingLp1Danes { get; set; }
        public virtual DbSet<Hr10CelaGpf3CuplerLp1Dane> Hr10CelaGpf3CuplerLp1Danes { get; set; }
        public virtual DbSet<Hr10CelaGpf3OutletBushingLp1Dane> Hr10CelaGpf3OutletBushingLp1Danes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.16.6.216,1433\\SQLEXPRESS_LV7; Initial Catalog= DaneProdukcyjne;Persist Security Info=True;User ID=daneprod;Password=12;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<Br10Cela1Dane>(entity =>
            {
                entity.ToTable("BR10_Cela_1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Br10Cela2Dane>(entity =>
            {
                entity.ToTable("BR10_Cela_2_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Br10Cela3Dane>(entity =>
            {
                entity.ToTable("BR10_Cela_3_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Br10Cela4Dane>(entity =>
            {
                entity.ToTable("BR10_Cela_4_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Br10Cela5Dane>(entity =>
            {
                entity.ToTable("BR10_Cela_5_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela0Lp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_0_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela1Lp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_1_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela1Lp2Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_1_LP2_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela2Lp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_2_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela2Lp2Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_2_LP2_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela3Lp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_3_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela3Lp2Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_3_LP2_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela3Lp3Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_3_LP3_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela4Lp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_4_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela4Lp2Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_4_LP2_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela4Lp3Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_4_LP3_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela5Lp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_5_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela5Lp2Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_5_LP2_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10Cela5Lp3Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_5_LP3_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10CelaGpf1Lp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_GPF_1_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10CelaGpf2Lp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_GPF_2_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10CelaGpf3BasicBushingLp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_GPF_3_BasicBushing_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10CelaGpf3CuplerLp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_GPF_3_Cupler_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            modelBuilder.Entity<Hr10CelaGpf3OutletBushingLp1Dane>(entity =>
            {
                entity.ToTable("HR10_Cela_GPF_3_OutletBushing_LP1_Dane");

                entity.Property(e => e.DataCzas).HasColumnType("datetime");

                entity.Property(e => e.NrKat).HasMaxLength(100);

                entity.Property(e => e.NrOperatora).HasMaxLength(20);

                entity.Property(e => e.Referencja).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
