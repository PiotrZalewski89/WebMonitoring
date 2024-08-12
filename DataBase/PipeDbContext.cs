using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebMonitoring.Table.PIPE;

#nullable disable

namespace WebMonitoring.DataBase
{
    public partial class PipeDbContext : DbContext
    {
        public PipeDbContext()
        {
        }

        public PipeDbContext(DbContextOptions<PipeDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ws7NgcAssembling> Ws7NgcAssemblings { get; set; }
        public virtual DbSet<Ws7NgcFinalLeakTester> Ws7NgcFinalLeakTesters { get; set; }
        public virtual DbSet<Ws7NgcMarking> Ws7NgcMarkings { get; set; }
        public virtual DbSet<Ws7SdfAssembling> Ws7SdfAssemblings { get; set; }
        public virtual DbSet<Ws7SdfControlLoop> Ws7SdfControlLoops { get; set; }
        public virtual DbSet<Ws7SdfFinalLeakTester> Ws7SdfFinalLeakTesters { get; set; }
        public virtual DbSet<Ws7SdfMarking> Ws7SdfMarkings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.50.232,1433\\\\\\\\STORAGESTATION;Initial Catalog=PIPE;Persist Security Info=True;User ID=pkIPLAS;Password=pkIPLAS;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<Ws7NgcAssembling>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.EngravingCode })
                    .HasName("WS7_NGC_ASSEMBLING_PK");

                entity.ToTable("WS7_NGC_ASSEMBLING");

                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .HasComment("sSendToSave_String[0]");

                entity.Property(e => e.EngravingCode)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENGRAVING_CODE")
                    .HasComment("sSendToSave_String[1]");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI")
                    .HasComment("Data zapisu danych z PLC");

                entity.Property(e => e.FrameSeq)
                    .HasColumnName("FRAME_SEQ")
                    .HasComment("Tech ETL");

                entity.Property(e => e.FrameTime)
                    .HasColumnName("FRAME_TIME")
                    .HasComment("Tech ETL");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7NgcFinalLeakTester>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("WS7_NGC_FINAL_LEAK_TESTER_PK");

                entity.ToTable("WS7_NGC_FINAL_LEAK_TESTER");

                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .HasComment("sSendToSave_String[0]");

                entity.Property(e => e.Cisnienie)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN")
                    .HasComment("Jednostka ciśnienia");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI")
                    .HasComment("Data zapisu danych z PLC");

                entity.Property(e => e.FrameSeq)
                    .HasColumnName("FRAME_SEQ")
                    .HasComment("Tech ETL");

                entity.Property(e => e.FrameTime)
                    .HasColumnName("FRAME_TIME")
                    .HasComment("Tech ETL");

                entity.Property(e => e.Wyciek)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7NgcMarking>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("WS7_NGC_MARKING_PK");

                entity.ToTable("WS7_NGC_MARKING");

                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .HasComment("sSendToSave_String[0]");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI")
                    .HasComment("Data zapisu danych z PLC");

                entity.Property(e => e.EngravingCode)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENGRAVING_CODE");

                entity.Property(e => e.FrameSeq)
                    .HasColumnName("FRAME_SEQ")
                    .HasComment("Tech ETL");

                entity.Property(e => e.FrameTime)
                    .HasColumnName("FRAME_TIME")
                    .HasComment("Tech ETL");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7SdfAssembling>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.EngravingCode })
                    .HasName("WS7_SDF_ASSEMBLING_PK");

                entity.ToTable("WS7_SDF_ASSEMBLING");

                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .HasComment("sSendToSave_String[0]");

                entity.Property(e => e.EngravingCode)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENGRAVING_CODE")
                    .HasComment("sSendToSave_String[1]");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI")
                    .HasComment("Data zapisu danych z PLC");

                entity.Property(e => e.FrameSeq)
                    .HasColumnName("FRAME_SEQ")
                    .HasComment("Tech ETL");

                entity.Property(e => e.FrameTime)
                    .HasColumnName("FRAME_TIME")
                    .HasComment("Tech ETL");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7SdfControlLoop>(entity =>
            {
                entity.HasKey(e => e.EngravingCode)
                    .HasName("WS7_SDF_CONTROL_LOOP_PK");

                entity.ToTable("WS7_SDF_CONTROL_LOOP");

                entity.Property(e => e.EngravingCode)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENGRAVING_CODE");

                entity.Property(e => e.DtOperation)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERATION");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPERATOR_ID");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDER_NO");

                entity.Property(e => e.Quality)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("QUALITY");

                entity.Property(e => e.Result).HasColumnName("RESULT");
            });

            modelBuilder.Entity<Ws7SdfFinalLeakTester>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("WS7_SDF_FINAL_LEAK_TESTER_PK");

                entity.ToTable("WS7_SDF_FINAL_LEAK_TESTER");

                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .HasComment("sSendToSave_String[0]");

                entity.Property(e => e.Cisnienie)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN")
                    .HasComment("Jednostka ciśnienia");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI")
                    .HasComment("Data zapisu danych z PLC");

                entity.Property(e => e.FrameSeq)
                    .HasColumnName("FRAME_SEQ")
                    .HasComment("Tech ETL");

                entity.Property(e => e.FrameTime)
                    .HasColumnName("FRAME_TIME")
                    .HasComment("Tech ETL");

                entity.Property(e => e.Wyciek)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7SdfMarking>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("WS7_SDF_MARKING_PK");

                entity.ToTable("WS7_SDF_MARKING");

                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CODE")
                    .HasComment("sSendToSave_String[0]");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI")
                    .HasComment("Data zapisu danych z PLC");

                entity.Property(e => e.EngravingCode)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ENGRAVING_CODE");

                entity.Property(e => e.FrameSeq)
                    .HasColumnName("FRAME_SEQ")
                    .HasComment("Tech ETL");

                entity.Property(e => e.FrameTime)
                    .HasColumnName("FRAME_TIME")
                    .HasComment("Tech ETL");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
