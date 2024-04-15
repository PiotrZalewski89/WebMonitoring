using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebMonitoring.Table.CNH;

#nullable disable

namespace WebMonitoring.DataBase
{
    public partial class CnhDbContext : DbContext
    {
        public CnhDbContext()
        {
        }

        public CnhDbContext(DbContextOptions<CnhDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cnh529Check> Cnh529Checks { get; set; }
        public virtual DbSet<Cnh529Etap1> Cnh529Etap1s { get; set; }
        public virtual DbSet<Cnh529Etap2> Cnh529Etap2s { get; set; }
        public virtual DbSet<Cnh529Etap3> Cnh529Etap3s { get; set; }
        public virtual DbSet<Cnh529Etap4> Cnh529Etap4s { get; set; }
        public virtual DbSet<Cnh529FinalleakTester> Cnh529FinalleakTesters { get; set; }
        public virtual DbSet<Cnh529PreleakTesterSekcjaA> Cnh529PreleakTesterSekcjaAs { get; set; }
        public virtual DbSet<Cnh529PreleakTesterSekcjaB> Cnh529PreleakTesterSekcjaBs { get; set; }
        public virtual DbSet<CnhCheck> CnhChecks { get; set; }
        public virtual DbSet<CnhEtap1> CnhEtap1s { get; set; }
        public virtual DbSet<CnhEtap2> CnhEtap2s { get; set; }
        public virtual DbSet<CnhEtap3> CnhEtap3s { get; set; }
        public virtual DbSet<CnhEtap4> CnhEtap4s { get; set; }
        public virtual DbSet<CnhFinalleakTester> CnhFinalleakTesters { get; set; }
        public virtual DbSet<CnhPreleakTester> CnhPreleakTesters { get; set; }
        public virtual DbSet<CnhWs1MeasuredAssembly> CnhWs1MeasuredAssemblies { get; set; }
        public virtual DbSet<CnhWs2Shell> CnhWs2Shells { get; set; }
        public virtual DbSet<Ws1CnhCleaningL3> Ws1CnhCleaningL3s { get; set; }
        public virtual DbSet<Ws1CnhEtap1> Ws1CnhEtap1s { get; set; }
        public virtual DbSet<Ws1CnhEtap2> Ws1CnhEtap2s { get; set; }
        public virtual DbSet<Ws1CnhFinalLeaktesterL3> Ws1CnhFinalLeaktesterL3s { get; set; }
        public virtual DbSet<Ws1CnhLeakTesterEtap1> Ws1CnhLeakTesterEtap1s { get; set; }
        public virtual DbSet<Ws1CnhLeakTesterEtap2> Ws1CnhLeakTesterEtap2s { get; set; }
        public virtual DbSet<Ws1CnhPetlaKontrolnaL3> Ws1CnhPetlaKontrolnaL3s { get; set; }
        public virtual DbSet<Ws1CnhSkladanieOslon> Ws1CnhSkladanieOslons { get; set; }
        public virtual DbSet<Ws1CnhVisualStationL3> Ws1CnhVisualStationL3s { get; set; }
        public virtual DbSet<Ws5CnhPetlaKontrolnaL1> Ws5CnhPetlaKontrolnaL1s { get; set; }
        public virtual DbSet<Ws6CnhPetlaKontrolnaL2> Ws6CnhPetlaKontrolnaL2s { get; set; }
        public virtual DbSet<Ws7TtFinalGauge> Ws7TtFinalGauges { get; set; }
        public virtual DbSet<Ws7TtFinalLeakTester> Ws7TtFinalLeakTesters { get; set; }
        public virtual DbSet<Ws7TtManualWeldingOp360> Ws7TtManualWeldingOp360s { get; set; }
        public virtual DbSet<Ws7TtMarking> Ws7TtMarkings { get; set; }
        public virtual DbSet<Ws7TtOp380> Ws7TtOp380s { get; set; }
        public virtual DbSet<Ws7TtPetlaKontrolnaL4> Ws7TtPetlaKontrolnaL4s { get; set; }
        public virtual DbSet<Ws7TtPreleakTester> Ws7TtPreleakTesters { get; set; }
        public virtual DbSet<Ws7TtReworkSt> Ws7TtReworkSts { get; set; }
        public virtual DbSet<Ws7TtWeldingCell2Op290Stn1> Ws7TtWeldingCell2Op290Stn1s { get; set; }
        public virtual DbSet<Ws7TtWeldingCell2Op300Stn1> Ws7TtWeldingCell2Op300Stn1s { get; set; }
        public virtual DbSet<Ws7TtWeldingCell2Op310Stn2> Ws7TtWeldingCell2Op310Stn2s { get; set; }
        public virtual DbSet<Ws7TtWeldingCell3Op320Stn1> Ws7TtWeldingCell3Op320Stn1s { get; set; }
        public virtual DbSet<Ws7TtWeldingCell3Op325Stn1> Ws7TtWeldingCell3Op325Stn1s { get; set; }
        public virtual DbSet<Ws7TtWeldingCell3Op330Stn2> Ws7TtWeldingCell3Op330Stn2s { get; set; }
        public virtual DbSet<Ws7TtWeldingCell3Op390Stn2> Ws7TtWeldingCell3Op390Stn2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=KATCON-L203\\MYLOCALSQL;DataBase=CNH;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<Cnh529Check>(entity =>
            {
                entity.HasKey(e => e.NrOslony)
                    .HasName("CNH_529_CHECK_PK");

                entity.ToTable("CNH_529_CHECK");

                entity.HasIndex(e => e.DtOperacji, "CNH_529_CHECK_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "CNH_529_CHECK_FRAME_TIME_IDX");

                entity.Property(e => e.NrOslony)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_OSLONY")
                    .HasComment("Nr osłony");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Cnh529Etap1>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("CNH_529_ETAP1_PK");

                entity.ToTable("CNH_529_ETAP1");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Cnh529Etap2>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("CNH_529_ETAP2_PK");

                entity.ToTable("CNH_529_ETAP2");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Cnh529Etap3>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("CNH_529_ETAP3_PK");

                entity.ToTable("CNH_529_ETAP3");

                entity.HasIndex(e => e.DtOperacji, "CNH_529_ETAP3_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "CNH_529_ETAP3_FRAME_TIME_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Cnh529Etap4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("CNH_529_ETAP4_PK");

                entity.ToTable("CNH_529_ETAP4");

                entity.HasIndex(e => e.DtOperacji, "CNH_529_ETAP4_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "CNH_529_ETAP4_FRAME_TIME_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Cnh529FinalleakTester>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrScrcuc, e.NrShellaDocDpf })
                    .HasName("CNH_529_FINALLEAK_TESTER_PK");

                entity.ToTable("CNH_529_FINALLEAK_TESTER");

                entity.HasIndex(e => e.DtOperacji, "CNH_529_FINALLEAK_TESTER_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "CNH_529_FINALLEAK_TESTER_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrOslony, "CNH_529_FINALLEAK_TESTER_NR_OSLONY_IDX");

                entity.Property(e => e.NrShellaScrScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCR_SCRCUC")
                    .HasComment("sZapisNrDoBazy[0] – Shell SCR-SCRCUC");

                entity.Property(e => e.NrShellaDocDpf)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC_DPF")
                    .HasComment("sZapisNrDoBazy[1] - Shell SCRoF");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
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

                entity.Property(e => e.NrOslony)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_OSLONY")
                    .HasComment("sZapisNrDoBazy[2] - Osłona");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Cnh529PreleakTesterSekcjaA>(entity =>
            {
                entity.HasKey(e => e.NrShellaScrScrcuc)
                    .HasName("CNH_529_PRELEAK_TESTER_PK");

                entity.ToTable("CNH_529_PRELEAK_TESTER_SEKCJA_A");

                entity.HasIndex(e => e.DtOperacji, "CNH_529_PRELEAK_TESTER_SEKCJA_A_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "CNH_529_PRELEAK_TESTER_SEKCJA_A_FRAME_TIME_IDX");

                entity.Property(e => e.NrShellaScrScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCR_SCRCUC")
                    .HasComment("sSendToSave_String[0] – Shell");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Cnh529PreleakTesterSekcjaB>(entity =>
            {
                entity.HasKey(e => e.NrShellaDocDpf)
                    .HasName("CNH_529_PRELEAK_TESTER_SEKCJA_B_PK");

                entity.ToTable("CNH_529_PRELEAK_TESTER_SEKCJA_B");

                entity.HasIndex(e => e.DtOperacji, "CNH_529_PRELEAK_TESTER_SEKCJA_B_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "CNH_529_PRELEAK_TESTER_SEKCJA_B_FRAME_TIME_IDX");

                entity.Property(e => e.NrShellaDocDpf)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC_DPF")
                    .HasComment("sSendToSave_String[0] – Shell");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<CnhCheck>(entity =>
            {
                entity.HasKey(e => e.NrOslony)
                    .HasName("CNH_CHECK_PK");

                entity.ToTable("CNH_CHECK");

                entity.HasIndex(e => e.DtOperacji, "CNH_CHECK_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "CNH_CHECK_FRAME_TIME_IDX");

                entity.Property(e => e.NrOslony)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_OSLONY")
                    .HasComment("Nr osłony");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<CnhEtap1>(entity =>
            {
                entity.HasKey(e => e.NrShellaDoc)
                    .HasName("CNH_ETAP1_PK");

                entity.ToTable("CNH_ETAP1");

                entity.HasIndex(e => e.FrameTime, "CNH_ETAP1_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "CNH_ETAP1_MONITORING_IDX");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("sSendToSave_String[0] – Shell DOC");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<CnhEtap2>(entity =>
            {
                entity.HasKey(e => e.NrShellaScrof)
                    .HasName("CNH_ETAP2_PK");

                entity.ToTable("CNH_ETAP2");

                entity.HasIndex(e => e.FrameTime, "CNH_ETAP2_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "CNH_ETAP2_MONITORING_IDX");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("sSendToSave_String[1] - Shell SCRoF");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<CnhEtap3>(entity =>
            {
                entity.HasKey(e => e.NrShellaScrcuc)
                    .HasName("CNH_ETAP3_PK");

                entity.ToTable("CNH_ETAP3");

                entity.HasIndex(e => e.FrameTime, "CNH_ETAP3_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "CNH_ETAP3_MONITORING_IDX");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("sSendToSave_String[1] - Shell SCRCUC");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<CnhEtap4>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrShellaScrcuc, e.NrMixer, e.NrOslony })
                    .HasName("CNH_ETAP4_PK");

                entity.ToTable("CNH_ETAP4");

                entity.HasIndex(e => e.FrameTime, "CNH_ETAP4_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "CNH_ETAP4_MONITORING_IDX");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("sSendToSave_String[1] - Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("sSendToSave_String[0] – Shell DOC");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("sSendToSave_String[2] - Shell SCRCUC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("sSendToSave_String[3] - Mixer");

                entity.Property(e => e.NrOslony)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_OSLONY")
                    .HasComment("sSendToSave_String[4] - Osłona");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<CnhFinalleakTester>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrShellaScrcuc, e.NrMixer, e.NrOslony })
                    .HasName("CNH_FINALLEAK_TESTER_PK");

                entity.ToTable("CNH_FINALLEAK_TESTER");

                entity.HasIndex(e => e.FrameTime, "CNH_FINALLEAK_TESTER_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "CNH_FINALLEAK_TESTER_MONITORING_IDX");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("sSendToSave_String[1] - Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("sSendToSave_String[0] – Shell DOC");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("sSendToSave_String[2] - Shell SCRCUC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("sSendToSave_String[3] - Mixer");

                entity.Property(e => e.NrOslony)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_OSLONY")
                    .HasComment("sSendToSave_String[4] - Osłona");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<CnhPreleakTester>(entity =>
            {
                entity.HasKey(e => e.NrMixer)
                    .HasName("CNH_PRELEAK_TESTER_PK");

                entity.ToTable("CNH_PRELEAK_TESTER");

                entity.HasIndex(e => e.FrameTime, "CNH_PRELEAK_TESTER_FRAME_TIME_IDX");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("sSendToSave_String[0] – Shell DOC");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<CnhWs1MeasuredAssembly>(entity =>
            {
                entity.HasKey(e => e.ShellSerialNum)
                    .HasName("CNH_WS1_MeasuredAssemblies_PK");

                entity.ToTable("CNH_WS1_MeasuredAssemblies");

                entity.HasIndex(e => e.FrameTime, "CNH_WS1_MeasuredAssemblies_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.ShellSerialNum, e.Pass }, "CNH_WS1_MeasuredAssemblies_SHELL_SERIAL_NUM_PASS_IDX");

                entity.Property(e => e.ShellSerialNum)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("SHELL_SERIAL_NUM")
                    .HasComment("vShellSerialNum");

                entity.Property(e => e.Brick1SerialNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BRICK1_SERIAL_NUM")
                    .HasComment("vBrick1SerialNum");

                entity.Property(e => e.Brick2SerialNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BRICK2_SERIAL_NUM")
                    .HasComment("vBrick2SerialNum");

                entity.Property(e => e.DtAssembly)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_ASSEMBLY")
                    .HasComment("dtAssembly");

                entity.Property(e => e.FrameSeq)
                    .HasColumnName("FRAME_SEQ")
                    .HasComment("Tech ETL");

                entity.Property(e => e.FrameTime)
                    .HasColumnName("FRAME_TIME")
                    .HasComment("Tech ETL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("nAssemblyUid");

                entity.Property(e => e.MachId)
                    .HasColumnName("MACH_ID")
                    .HasComment("nMachID");

                entity.Property(e => e.Mat1SerialNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAT1_SERIAL_NUM")
                    .HasComment("vMat1SerialNum");

                entity.Property(e => e.Mat2SerialNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAT2_SERIAL_NUM")
                    .HasComment("vMat2SerialNum");

                entity.Property(e => e.PartNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PART_NUM")
                    .HasComment("vPartNum");

                entity.Property(e => e.Pass)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASS")
                    .IsFixedLength(true)
                    .HasComment("bPass -> T|N");
            });

            modelBuilder.Entity<CnhWs2Shell>(entity =>
            {
                entity.HasKey(e => e.ShellSerialNum)
                    .HasName("CNH_WS2_Shells_PK");

                entity.ToTable("CNH_WS2_Shells");

                entity.HasIndex(e => e.FrameTime, "CNH_WS2_Shells_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.ShellSerialNum, e.Pass }, "CNH_WS2_Shells_SHELL_SERIAL_NUM_PASS_IDX");

                entity.Property(e => e.ShellSerialNum)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("SHELL_SERIAL_NUM")
                    .HasComment("vShellSerialNum");

                entity.Property(e => e.DtMeasure)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_MEASURE")
                    .HasComment("dtMeasure");

                entity.Property(e => e.FrameSeq)
                    .HasColumnName("FRAME_SEQ")
                    .HasComment("Tech ETL");

                entity.Property(e => e.FrameTime)
                    .HasColumnName("FRAME_TIME")
                    .HasComment("Tech ETL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("nAssemblyUid");

                entity.Property(e => e.PartNum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PART_NUM")
                    .HasComment("vPartNum");

                entity.Property(e => e.Pass)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PASS")
                    .IsFixedLength(true)
                    .HasComment("bPass -> T|N");
            });

            modelBuilder.Entity<Ws1CnhCleaningL3>(entity =>
            {
                entity.ToTable("WS1_CNH_CLEANING_L3");

                entity.HasIndex(e => e.FrameTime, "WS1_CNH_CLEANING_L32_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrKatalizatora, "WS1_CNH_CLEANING_L3_NR_KAT_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrKatalizatora)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NR_OPERATORA")
                    .HasComment("Nr Operatora");

                entity.Property(e => e.NrPaleta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_PALETA")
                    .HasComment("Nr palety");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws1CnhEtap1>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("WS1_CNH_ETAP1_PK");

                entity.ToTable("WS1_CNH_ETAP1");

                entity.HasIndex(e => e.FrameTime, "WS1_CNH_ETAP1_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.NrBasic, e.NrShell }, "WS1_CNH_ETAP1_NR_SHELLS");

                entity.HasIndex(e => e.NrShell, "WS1_CNH_ETAP1_NR_SHELL_KATCON");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("Kod basic z STF");

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

                entity.Property(e => e.NrShell)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELL")
                    .HasComment("Kod Basic Katcon");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws1CnhEtap2>(entity =>
            {
                entity.HasKey(e => e.NrShell)
                    .HasName("WS1_CNH_ETAP2_PK");

                entity.ToTable("WS1_CNH_ETAP2");

                entity.HasIndex(e => e.FrameTime, "WS1_CNH_ETAP2_FRAME_TIME_IDX");

                entity.Property(e => e.NrShell)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELL")
                    .HasComment("Kod Basic Katcon");

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

                entity.Property(e => e.NrBasic)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws1CnhFinalLeaktesterL3>(entity =>
            {
                entity.ToTable("WS1_CNH_FINAL_LEAKTESTER_L3");

                entity.HasIndex(e => e.DtOperacji, "WS1_CNH_FINAL_LEAKTESTER_L3_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "WS1_CNH_FINAL_LEAKTESTER_L3_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrWygenerowany, "WS1_CNH_PETLA_KONTROLNA_L3_NR_KAT_IDX");

                entity.HasIndex(e => e.NrShella, "WS1_CNH_PETLA_KONTROLNA_L3_NR_SHELL_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
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

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("sNrDoZapisuSql[1] – Shell");

                entity.Property(e => e.NrWygenerowany)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_WYGENEROWANY")
                    .HasComment("sNrDoZapisuSql[1] - Wygenerowany nr");

                entity.Property(e => e.ReworkGrawerki).HasColumnName("REWORK_GRAWERKI");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws1CnhLeakTesterEtap1>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("WS1_CNH_LEAK_TESTER_ETAP_1_PK");

                entity.ToTable("WS1_CNH_LEAK_TESTER_ETAP_1");

                entity.HasIndex(e => e.DtOperacji, "WS1_CNH_LEAK_TESTER_ETAP_1_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "WS1_CNH_LEAK_TESTER_ETAP_1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrShell, "WS1_CNH_LEAK_TESTER_ETAP_1_NR_SHELL_IDX");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("basic STF");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
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

                entity.Property(e => e.NrShell)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELL")
                    .HasComment("nr shell pod etapie 1");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws1CnhLeakTesterEtap2>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("WS1_CNH_LEAK_TESTER_ETAP_2_PK");

                entity.ToTable("WS1_CNH_LEAK_TESTER_ETAP_2");

                entity.HasIndex(e => e.DtOperacji, "WS1_CNH_LEAK_TESTER_ETAP_2_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "WS1_CNH_LEAK_TESTER_ETAP_2_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrShell, "WS1_CNH_LEAK_TESTER_ETAP_2_NR_SHELL_IDX");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("basic STF");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
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

                entity.Property(e => e.NrShell)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELL")
                    .HasComment("nr shell pod etapie 2");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws1CnhPetlaKontrolnaL3>(entity =>
            {
                entity.ToTable("WS1_CNH_PETLA_KONTROLNA_L3");

                entity.HasIndex(e => e.FrameTime, "WS1_CNH_PETLA_KONTROLNA_L3_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrKatalizatora, "WS1_CNH_PETLA_KONTROLNA_L3_NR_KAT_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AngleInlet)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ANGLE_INLET");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrKatalizatora)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NR_OPERATORA")
                    .HasComment("Nr Operatora");

                entity.Property(e => e.NrPaleta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_PALETA")
                    .HasComment("Nr palety");

                entity.Property(e => e.Quality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QUALITY");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws1CnhSkladanieOslon>(entity =>
            {
                entity.HasKey(e => e.NrShell)
                    .HasName("WS1_CNH_SKLADANIE_OSLON_PK");

                entity.ToTable("WS1_CNH_SKLADANIE_OSLON");

                entity.HasIndex(e => e.FrameTime, "WS1_CNH_SKLADANIE_OSLON_FRAME_TIME_IDX");

                entity.Property(e => e.NrShell)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELL")
                    .HasComment("Kod Basic Katcon");

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

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws1CnhVisualStationL3>(entity =>
            {
                entity.ToTable("WS1_CNH_VISUAL_STATION_L3");

                entity.HasIndex(e => e.DtOperacji, "WS1_CNH_VISUAL_STATION_L3_DT_ISX");

                entity.HasIndex(e => e.FrameTime, "WS1_CNH_VISUAL_STATION_L3_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.NrKatalizatora, e.WynikOperacji, e.FrameTime }, "WS1_CNH_VISUAL_STATION_L3_IDX");

                entity.HasIndex(e => e.NrKatalizatora, "WS1_CNH_VISUAL_STATION_L3_NR_KAT_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrKatalizatora)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Uwagi)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("UWAGI");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Ws5CnhPetlaKontrolnaL1>(entity =>
            {
                entity.ToTable("WS5_CNH_PETLA_KONTROLNA_L1");

                entity.HasIndex(e => e.DtOperacji, "WS5_CNH_PETLA_KONTROLNA_L1_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "WS5_CNH_PETLA_KONTROLNA_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrKatalizatora, "WS5_CNH_PETLA_KONTROLNA_L1_NR_KAT_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrKatalizatora)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NR_OPERATORA")
                    .HasComment("Nr Operatora");

                entity.Property(e => e.NrPaleta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_PALETA")
                    .HasComment("Nr palety");

                entity.Property(e => e.Quality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QUALITY");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws6CnhPetlaKontrolnaL2>(entity =>
            {
                entity.ToTable("WS6_CNH_PETLA_KONTROLNA_L2");

                entity.HasIndex(e => e.DtOperacji, "WS6_CNH_PETLA_KONTROLNA_L2_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "WS6_CNH_PETLA_KONTROLNA_L2_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrKatalizatora, "WS6_CNH_PETLA_KONTROLNA_L2_NR_KAT_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrKatalizatora)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NR_OPERATORA")
                    .HasComment("Nr Operatora");

                entity.Property(e => e.NrPaleta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_PALETA")
                    .HasComment("Nr palety");

                entity.Property(e => e.Quality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QUALITY");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtFinalGauge>(entity =>
            {
                entity.HasKey(e => e.NrOslony)
                    .HasName("WS7_TT_FINAL_GAUGE_PK");

                entity.ToTable("WS7_TT_FINAL_GAUGE");

                entity.HasIndex(e => e.DtOperacji, "WS7_TT_FINAL_GAUGE_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "WS7_TT_FINAL_GAUGE_FRAME_TIME_IDX");

                entity.Property(e => e.NrOslony)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_OSLONY")
                    .HasComment("Nr osłony");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtFinalLeakTester>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrShellaScrcuc, e.NrMixer, e.NrOslony })
                    .HasName("WS7_TT_FINAL_LEAK_TESTER_PK");

                entity.ToTable("WS7_TT_FINAL_LEAK_TESTER");

                entity.HasIndex(e => e.FrameTime, "WS7_TT_FINAL_LEAK_TESTER_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "WS7_TT_FINAL_LEAK_TESTER_MONITORING_IDX");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("sSendToSave_String[1] - Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("sSendToSave_String[0] – Shell DOC");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("sSendToSave_String[2] - Shell SCRCUC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("sSendToSave_String[3] - Mixer");

                entity.Property(e => e.NrOslony)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_OSLONY")
                    .HasComment("sSendToSave_String[4] - Osłona");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

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

            modelBuilder.Entity<Ws7TtManualWeldingOp360>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrShellaScrcuc, e.NrMixer })
                    .HasName("WS7_TT_MANUAL_WELDING_OP360_PK");

                entity.ToTable("WS7_TT_MANUAL_WELDING_OP360");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("Shell DOC");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("Shell SCRCUC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("Mixer");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtMarking>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrShellaScrcuc, e.NrMixer, e.NrOslony })
                    .HasName("WS7_TT_MARKING_PK");

                entity.ToTable("WS7_TT_MARKING");

                entity.HasIndex(e => e.FrameTime, "WS7_WS7_TT_MARKING_TESTER_FRAME_TIME_IDX");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("sSendToSave_String[1] - Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("sSendToSave_String[0] – Shell DOC");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("sSendToSave_String[2] - Shell SCRCUC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("sSendToSave_String[3] - Mixer");

                entity.Property(e => e.NrOslony)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_OSLONY")
                    .HasComment("sSendToSave_String[4] - Osłona");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtOp380>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrShellaScrcuc, e.NrMixer, e.NrOslony })
                    .HasName("WS7_TT_OP380_PK");

                entity.ToTable("WS7_TT_OP380");

                entity.HasIndex(e => e.FrameTime, "WS7_TT_OP380_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "WS7_TT_OP380_MONITORING_IDX");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("sSendToSave_String[1] - Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("sSendToSave_String[0] – Shell DOC");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("sSendToSave_String[2] - Shell SCRCUC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("sSendToSave_String[3] - Mixer");

                entity.Property(e => e.NrOslony)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_OSLONY")
                    .HasComment("sSendToSave_String[4] - Osłona");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtPetlaKontrolnaL4>(entity =>
            {
                entity.ToTable("WS7_TT_PETLA_KONTROLNA_L4");

                entity.HasIndex(e => e.DtOperacji, "WS7_TT_PETLA_KONTROLNA_L4_DT_IDX");

                entity.HasIndex(e => e.FrameTime, "WS7_TT_PETLA_KONTROLNA_L4_FRAME_TIME_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrKatalizatora)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NR_OPERATORA")
                    .HasComment("Nr Operatora");

                entity.Property(e => e.NrPaleta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_PALETA")
                    .HasComment("Nr palety");

                entity.Property(e => e.Quality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QUALITY");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtPreleakTester>(entity =>
            {
                entity.HasKey(e => e.NrMixer)
                    .HasName("WS7_TT_PRELEAK_TESTER_PK");

                entity.ToTable("WS7_TT_PRELEAK_TESTER");

                entity.HasIndex(e => e.FrameTime, "WS7_TT_PRELEAK_TESTER_FRAME_TIME_IDX");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("sSendToSave_String[0] – Shell DOC");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE")
                    .HasComment("Wartość ciśnienia");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtReworkSt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WS7_TT_REWORK_ST");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdOperatora)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_OPERATORA");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODEL");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.Stanowisko).HasColumnName("STANOWISKO");

                entity.Property(e => e.WadaJakosciowa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WADA_JAKOSCIOWA");
            });

            modelBuilder.Entity<Ws7TtWeldingCell2Op290Stn1>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaDoc, e.NrMixer })
                    .HasName("WS7_TT_WELDING_CELL_1_OP290_STN1_PK");

                entity.ToTable("WS7_TT_WELDING_CELL_2_OP290_STN1");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("Shell DOC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("Mixer");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtWeldingCell2Op300Stn1>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrMixer })
                    .HasName("WS7_TT_WELDING_CELL_1_OP300_STN1_PK");

                entity.ToTable("WS7_TT_WELDING_CELL_2_OP300_STN1");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("Shell DOC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("Mixer");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtWeldingCell2Op310Stn2>(entity =>
            {
                entity.HasKey(e => e.NrShellaScrcuc)
                    .HasName("WS7_TT_WELDING_CELL_1_OP310_STN2_PK");

                entity.ToTable("WS7_TT_WELDING_CELL_2_OP310_STN2");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("Shell SCRCUC");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtWeldingCell3Op320Stn1>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrShellaScrcuc, e.NrMixer })
                    .HasName("WS7_TT_WELDING_CELL_3_STN1_PK");

                entity.ToTable("WS7_TT_WELDING_CELL_3_OP320_STN1");

                entity.HasIndex(e => e.FrameTime, "WS7_TT_WELDING_CELL_3_STN1_FRAME_TIME_IDX");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("Shell DOC");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("Shell SCRCUC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("Mixer");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtWeldingCell3Op325Stn1>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrShellaScrcuc, e.NrMixer })
                    .HasName("WS7_TT_WELDING_CELL_3_OP325_STN1_PK");

                entity.ToTable("WS7_TT_WELDING_CELL_3_OP325_STN1");

                entity.HasIndex(e => e.FrameTime, "WS7_TT_WELDING_CELL_3_OP325_STN1_FRAME_TIME_IDX");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("Shell DOC");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("Shell SCRCUC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("Mixer");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtWeldingCell3Op330Stn2>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrShellaScrcuc, e.NrMixer })
                    .HasName("WS7_TT_WELDING_CELL_3_OP330_STN1_PK");

                entity.ToTable("WS7_TT_WELDING_CELL_3_OP330_STN2");

                entity.HasIndex(e => e.FrameTime, "WS7_TT_WELDING_CELL_3_OP330_STN1_FRAME_TIME_IDX");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("Shell DOC");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("Shell SCRCUC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("Mixer");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Ws7TtWeldingCell3Op390Stn2>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc, e.NrShellaScrcuc, e.NrMixer, e.NrOslona })
                    .HasName("WS7_TT_WELDING_CELL_3_OP390_STN1_PK");

                entity.ToTable("WS7_TT_WELDING_CELL_3_OP390_STN2");

                entity.HasIndex(e => e.FrameTime, "WS7_TT_WELDING_CELL_3_OP390_STN2_FRAME_TIME_IDX");

                entity.Property(e => e.NrShellaScrof)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCROF")
                    .HasComment("Shell SCRoF");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("Shell DOC");

                entity.Property(e => e.NrShellaScrcuc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_SCRCUC")
                    .HasComment("Shell SCRCUC");

                entity.Property(e => e.NrMixer)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIXER")
                    .HasComment("Mixer");

                entity.Property(e => e.NrOslona)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_OSLONA")
                    .HasComment("Oslona");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

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
