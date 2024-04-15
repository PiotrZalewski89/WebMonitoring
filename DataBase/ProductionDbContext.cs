using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebMonitoring.Table.Production;

#nullable disable

namespace WebMonitoring.DataBase
{
    public partial class ProductionDbContext : DbContext
    {
        public ProductionDbContext()
        {
        }

        public ProductionDbContext(DbContextOptions<ProductionDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProductionPlan> ProductionPlans { get; set; }
        public virtual DbSet<Referencja> Referencjas { get; set; }
        public virtual DbSet<Weil> Weils { get; set; }
        public virtual DbSet<Ws2bCela2lp1> Ws2bCela2lp1s { get; set; }
        public virtual DbSet<Ws3Cela0lp1> Ws3Cela0lp1s { get; set; }
        public virtual DbSet<Ws3Cela1lp1> Ws3Cela1lp1s { get; set; }
        public virtual DbSet<Ws3Cela1lp1Gpf> Ws3Cela1lp1Gpfs { get; set; }
        public virtual DbSet<Ws3Cela1lp1Rurki> Ws3Cela1lp1Rurkis { get; set; }
        public virtual DbSet<Ws3Cela1lp2> Ws3Cela1lp2s { get; set; }
        public virtual DbSet<Ws3Cela1lp2Rurki> Ws3Cela1lp2Rurkis { get; set; }
        public virtual DbSet<Ws3Cela2lp1> Ws3Cela2lp1s { get; set; }
        public virtual DbSet<Ws3Cela2lp1Gpf> Ws3Cela2lp1Gpfs { get; set; }
        public virtual DbSet<Ws3Cela2lp2> Ws3Cela2lp2s { get; set; }
        public virtual DbSet<Ws3Cela3lp1Gpf> Ws3Cela3lp1Gpfs { get; set; }
        public virtual DbSet<Ws3Cela5lp1> Ws3Cela5lp1s { get; set; }
        public virtual DbSet<Ws3Cela5lp2> Ws3Cela5lp2s { get; set; }
        public virtual DbSet<Ws3Cela5lp3> Ws3Cela5lp3s { get; set; }
        public virtual DbSet<Ws4Cela1> Ws4Cela1s { get; set; }
        public virtual DbSet<Ws4Cela2> Ws4Cela2s { get; set; }
        public virtual DbSet<Ws4Cela3> Ws4Cela3s { get; set; }
        public virtual DbSet<Ws4Cela4> Ws4Cela4s { get; set; }
        public virtual DbSet<Ws4Cela5> Ws4Cela5s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.50.232,1433\\\\\\\\STORAGESTATION;Initial Catalog=Production;Persist Security Info=True;User ID=pkIPLAS;Password=pkIPLAS;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<ProductionPlan>(entity =>
            {
                entity.ToTable("ProductionPlan");

                entity.Property(e => e.Line)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.ProductionShift)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Referencja>(entity =>
            {
                entity.ToTable("Referencja");

                entity.Property(e => e.Model).HasMaxLength(20);

                entity.Property(e => e.ReferencjaKatcon).HasMaxLength(20);

                entity.Property(e => e.ReferencjaKlient).HasMaxLength(20);
            });

            modelBuilder.Entity<Weil>(entity =>
            {
                entity.ToTable("Weil");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws2bCela2lp1>(entity =>
            {
                entity.ToTable("WS2B_Cela_2LP1");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela0lp1>(entity =>
            {
                entity.ToTable("WS3_Cela_0LP1");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_0LP1_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela1lp1>(entity =>
            {
                entity.ToTable("WS3_Cela_1LP1");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_1LP1_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela1lp1Gpf>(entity =>
            {
                entity.ToTable("WS3_Cela_1LP1_GPF");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_1LP1_GPF_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela1lp1Rurki>(entity =>
            {
                entity.ToTable("WS3_Cela_1LP1_RURKI");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela1lp2>(entity =>
            {
                entity.ToTable("WS3_Cela_1LP2");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_1LP2_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela1lp2Rurki>(entity =>
            {
                entity.ToTable("WS3_Cela_1LP2_RURKI");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela2lp1>(entity =>
            {
                entity.ToTable("WS3_Cela_2LP1");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_2LP1_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela2lp1Gpf>(entity =>
            {
                entity.ToTable("WS3_Cela_2LP1_GPF");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_2LP1_GPF_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela2lp2>(entity =>
            {
                entity.ToTable("WS3_Cela_2LP2");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_2LP2_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela3lp1Gpf>(entity =>
            {
                entity.ToTable("WS3_Cela_3LP1_GPF");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_3LP1_GPF_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela5lp1>(entity =>
            {
                entity.ToTable("WS3_Cela_5LP1");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_5LP1_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela5lp2>(entity =>
            {
                entity.ToTable("WS3_Cela_5LP2");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_5LP2_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws3Cela5lp3>(entity =>
            {
                entity.ToTable("WS3_Cela_5LP3");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS3_Cela_5LP3_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws4Cela1>(entity =>
            {
                entity.ToTable("WS4_Cela_1");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS4_Cela_1_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws4Cela2>(entity =>
            {
                entity.ToTable("WS4_Cela_2");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS4_Cela_2_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws4Cela3>(entity =>
            {
                entity.ToTable("WS4_Cela_3");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS4_Cela_3_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws4Cela4>(entity =>
            {
                entity.ToTable("WS4_Cela_4");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS4_Cela_4_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            modelBuilder.Entity<Ws4Cela5>(entity =>
            {
                entity.ToTable("WS4_Cela_5");

                entity.HasIndex(e => new { e.Model, e.FrameTime }, "WS4_Cela_5_MODEL_FRAME_TIME_IDX");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IloscSztuk).HasColumnName("ILOSC_SZTUK");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .HasColumnName("MODEL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
