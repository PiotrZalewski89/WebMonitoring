using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebMonitoring.Table.V50;

#nullable disable

namespace WebMonitoring.DataBase
{
    public partial class V50_DbContext : DbContext
    {
        public V50_DbContext()
        {
        }

        public V50_DbContext(DbContextOptions<V50_DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<V50Checkfixture> V50Checkfixtures { get; set; }
        public virtual DbSet<V50Etap1> V50Etap1s { get; set; }
        public virtual DbSet<V50FinalleakTester> V50FinalleakTesters { get; set; }
        public virtual DbSet<V50PetlaKontrolnaL1> V50PetlaKontrolnaL1s { get; set; }
        public virtual DbSet<V50PreleakTester> V50PreleakTesters { get; set; }
        public virtual DbSet<V50Reprint> V50Reprints { get; set; }
        public virtual DbSet<V50Torque> V50Torques { get; set; }
        public virtual DbSet<V50Ws1MeasuredAssembly> V50Ws1MeasuredAssemblies { get; set; }
        public virtual DbSet<V50Ws2Shell> V50Ws2Shells { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.50.232,1433\\STORAGESTATION;Initial Catalog=V50;Persist Security Info=True;User ID=pkIPLAS;Password=pkIPLAS;MultipleActiveResultSets=True;Application Name=EntityFramework");
                //optionsBuilder.UseSqlServer("Data Source=KATCON-L106\\SQLEXPRESS;Initial Catalog=V50;Persist Security Info=True;User ID=pkIPLAS_;Password=pkIPLAS_;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<V50Checkfixture>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc })
                    .HasName("V50_CHECKFIXTURE_PK");

                entity.ToTable("V50_CHECKFIXTURE", "dbo");

                entity.HasIndex(e => e.FrameTime, "V50_CHECKFIXTURE_FRAME_TIME_IDX");

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

            modelBuilder.Entity<V50Etap1>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaDoc, e.NrShellaScrof })
                    .HasName("V50_ETAP1_PK");

                entity.ToTable("V50_ETAP1", "dbo");

                entity.HasIndex(e => e.FrameTime, "V50_ETAP1_FT_IDX");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("sSendToSave_String[0] – Shell DOC");

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

            modelBuilder.Entity<V50FinalleakTester>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc })
                    .HasName("V50_FINALLEAK_TESTER_PK");

                entity.ToTable("V50_FINALLEAK_TESTER", "dbo");

                entity.HasIndex(e => e.FrameTime, "V50_FINALLEAK_TESTER_FRAME_TIME_IDX");

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

            modelBuilder.Entity<V50PetlaKontrolnaL1>(entity =>
            {
                entity.ToTable("V50_PETLA_KONTROLNA_L1", "dbo");

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

                entity.Property(e => e.NrPzzw)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_PZZW")
                    .HasComment("Nr zlecenia PZZW");

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

            modelBuilder.Entity<V50PreleakTester>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaDoc, e.NrShellaScrof })
                    .HasName("V50_PRELEAK_TESTER_PK");

                entity.ToTable("V50_PRELEAK_TESTER", "dbo");

                entity.HasIndex(e => e.FrameTime, "V50_PRELEAK_TESTER_FT_IDX");

                entity.Property(e => e.NrShellaDoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_DOC")
                    .HasComment("sSendToSave_String[0] – Shell DOC");

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

            modelBuilder.Entity<V50Reprint>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc })
                    .HasName("V50_REPRINT_PK");

                entity.ToTable("V50_REPRINT", "dbo");

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

            modelBuilder.Entity<V50Torque>(entity =>
            {
                entity.HasKey(e => new { e.NrShellaScrof, e.NrShellaDoc })
                    .HasName("V50_TORQUE_PK");

                entity.ToTable("V50_TORQUE", "dbo");

                entity.HasIndex(e => e.FrameTime, "V50_TORQUE_FRAME_TIME_IDX");

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

            modelBuilder.Entity<V50Ws1MeasuredAssembly>(entity =>
            {
                entity.HasKey(e => e.ShellSerialNum)
                    .HasName("V50_WS1_MeasuredAssemblies_PK");

                entity.ToTable("V50_WS1_MeasuredAssemblies", "dbo");

                entity.HasIndex(e => e.FrameTime, "V50_WS1_MeasuredAssemblies_FT_IDX");

                entity.HasIndex(e => new { e.ShellSerialNum, e.Pass }, "V50_WS1_MeasuredAssemblies_PASS_IDX");

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
                    .HasMaxLength(8)
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

            modelBuilder.Entity<V50Ws2Shell>(entity =>
            {
                entity.HasKey(e => e.ShellSerialNum)
                    .HasName("V50_WS2_Shells_PK");

                entity.ToTable("V50_WS2_Shells", "dbo");

                entity.HasIndex(e => e.FrameTime, "V50_WS2_Shells_FT_IDX");

                entity.HasIndex(e => new { e.ShellSerialNum, e.Pass }, "V50_WS2_Shells_PASS_IDX");

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
                    .HasMaxLength(8)
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
