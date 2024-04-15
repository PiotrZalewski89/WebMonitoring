using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebMonitoring.Table.StorageStation;

#nullable disable

namespace WebMonitoring.DataBase
{
    public partial class StorageStationDbContext : DbContext
    {
        public StorageStationDbContext()
        {
        }

        public StorageStationDbContext(DbContextOptions<StorageStationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cela1And2Hr16L3> Cela1And2Hr16L3s { get; set; }
        public virtual DbSet<Cela3Hr16L3> Cela3Hr16L3s { get; set; }
        public virtual DbSet<Cela5AbbBr10L2> Cela5AbbBr10L2s { get; set; }
        public virtual DbSet<Cela8AbbL1> Cela8AbbL1s { get; set; }
        public virtual DbSet<CheckFixtureL1> CheckFixtureL1s { get; set; }
        public virtual DbSet<EnkapsulacjaBr10L2> EnkapsulacjaBr10L2s { get; set; }
        public virtual DbSet<FinalGaugeBr10L2> FinalGaugeBr10L2s { get; set; }
        public virtual DbSet<FinalGaugeHr16L3> FinalGaugeHr16L3s { get; set; }
        public virtual DbSet<FinalLeaktesterHr16L3> FinalLeaktesterHr16L3s { get; set; }
        public virtual DbSet<FinalleakTesterL1> FinalleakTesterL1s { get; set; }
        public virtual DbSet<GbdIoCalibrationBr10L2> GbdIoCalibrationBr10L2s { get; set; }
        public virtual DbSet<HomologationL1> HomologationL1s { get; set; }
        public virtual DbSet<InletPressL1> InletPressL1s { get; set; }
        public virtual DbSet<LeakTesterBr10L2> LeakTesterBr10L2s { get; set; }
        public virtual DbSet<M260BracketChecksL4> M260BracketChecksL4s { get; set; }
        public virtual DbSet<M260ControlLoopL4> M260ControlLoopL4s { get; set; }
        public virtual DbSet<M260EncapsulationBodyL4> M260EncapsulationBodyL4s { get; set; }
        public virtual DbSet<M260EncapsulationPipeL4> M260EncapsulationPipeL4s { get; set; }
        public virtual DbSet<M260GbdIoCalibrationL4> M260GbdIoCalibrationL4s { get; set; }
        public virtual DbSet<M260GeometryGaugeL4> M260GeometryGaugeL4s { get; set; }
        public virtual DbSet<M260LeakTesterAndMarkingL4> M260LeakTesterAndMarkingL4s { get; set; }
        public virtual DbSet<M260PreleakTesterL4> M260PreleakTesterL4s { get; set; }
        public virtual DbSet<M260PressStationL4> M260PressStationL4s { get; set; }
        public virtual DbSet<M260ResistanceWeldingL4> M260ResistanceWeldingL4s { get; set; }
        public virtual DbSet<M260VacuumL4> M260VacuumL4s { get; set; }
        public virtual DbSet<OdkurzaczBr10L2> OdkurzaczBr10L2s { get; set; }
        public virtual DbSet<OdkurzaczHr10L1> OdkurzaczHr10L1s { get; set; }
        public virtual DbSet<OdkurzaczHr16L3> OdkurzaczHr16L3s { get; set; }
        public virtual DbSet<OutletPressL1> OutletPressL1s { get; set; }
        public virtual DbSet<PanelFontijneL1> PanelFontijneL1s { get; set; }
        public virtual DbSet<PetlaKontrolnaBr10L2> PetlaKontrolnaBr10L2s { get; set; }
        public virtual DbSet<PetlaKontrolnaHr10L1> PetlaKontrolnaHr10L1s { get; set; }
        public virtual DbSet<PetlaKontrolnaHr16L3> PetlaKontrolnaHr16L3s { get; set; }
        public virtual DbSet<PreleakTesterL1> PreleakTesterL1s { get; set; }
        public virtual DbSet<PreleaktesterHr16L3> PreleaktesterHr16L3s { get; set; }
        public virtual DbSet<ReworkBr10L2> ReworkBr10L2s { get; set; }
        public virtual DbSet<ReworkHr10L1> ReworkHr10L1s { get; set; }
        public virtual DbSet<ReworkHr16L3> ReworkHr16L3s { get; set; }
        public virtual DbSet<ReworkOslonHr10L1> ReworkOslonHr10L1s { get; set; }
        public virtual DbSet<TorqueScrewdriverL1> TorqueScrewdriverL1s { get; set; }
        public virtual DbSet<VCela1And2Hr16L3Monitoring> VCela1And2Hr16L3Monitorings { get; set; }
        public virtual DbSet<VCela3Hr16L3Monitoring> VCela3Hr16L3Monitorings { get; set; }
        public virtual DbSet<VCela5AbbBr10L2Monitoring> VCela5AbbBr10L2Monitorings { get; set; }
        public virtual DbSet<VCela8AbbL1Monitoring> VCela8AbbL1Monitorings { get; set; }
        public virtual DbSet<VCheckFixtureL1Monitoring> VCheckFixtureL1Monitorings { get; set; }
        public virtual DbSet<VEnkapsulacjaBr10L2Monitoring> VEnkapsulacjaBr10L2Monitorings { get; set; }
        public virtual DbSet<VFinalGaugeBr10L2Monitoring> VFinalGaugeBr10L2Monitorings { get; set; }
        public virtual DbSet<VFinalGaugeHr16L3Monitoring> VFinalGaugeHr16L3Monitorings { get; set; }
        public virtual DbSet<VFinalLeaktesterHr16L3Monitoring> VFinalLeaktesterHr16L3Monitorings { get; set; }
        public virtual DbSet<VFinalleakTesterMonitoring> VFinalleakTesterMonitorings { get; set; }
        public virtual DbSet<VHomologationL1Monitoring> VHomologationL1Monitorings { get; set; }
        public virtual DbSet<VInletPressL1Monitoring> VInletPressL1Monitorings { get; set; }
        public virtual DbSet<VLeakTesterBr10L2Monitoring> VLeakTesterBr10L2Monitorings { get; set; }
        public virtual DbSet<VOdkurzaczBr10L2Monitoring> VOdkurzaczBr10L2Monitorings { get; set; }
        public virtual DbSet<VOdkurzaczHr10L1Monitoring> VOdkurzaczHr10L1Monitorings { get; set; }
        public virtual DbSet<VOdkurzaczHr16L3Monitoring> VOdkurzaczHr16L3Monitorings { get; set; }
        public virtual DbSet<VOutletPressL1Monitoring> VOutletPressL1Monitorings { get; set; }
        public virtual DbSet<VPetlaKontrolnaBr10L2Monitoring> VPetlaKontrolnaBr10L2Monitorings { get; set; }
        public virtual DbSet<VPetlaKontrolnaHr10L1Monitoring> VPetlaKontrolnaHr10L1Monitorings { get; set; }
        public virtual DbSet<VPetlaKontrolnaHr16L3Monitoring> VPetlaKontrolnaHr16L3Monitorings { get; set; }
        public virtual DbSet<VPreleakTesterMonitoring> VPreleakTesterMonitorings { get; set; }
        public virtual DbSet<VPreleaktesterHr16L3Monitoirng> VPreleaktesterHr16L3Monitoirngs { get; set; }
        public virtual DbSet<VTorqueScrewdriverL1Monitoring> VTorqueScrewdriverL1Monitorings { get; set; }
        public virtual DbSet<VWkretakL2Monitoring> VWkretakL2Monitorings { get; set; }
        public virtual DbSet<WiremeshBr10L2> WiremeshBr10L2s { get; set; }
        public virtual DbSet<WkretakBr10L2> WkretakBr10L2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.27.50.232,1433\\\\\\\\STORAGESTATION;Initial Catalog=StorageStation;Persist Security Info=True;User ID=pkIPLAS;Password=pkIPLAS;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<Cela1And2Hr16L3>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("CELA_1_AND_2_HR16_L3_PK");

                entity.ToTable("CELA_1_AND_2_HR16_L3");

                entity.HasIndex(e => e.FrameTime2, "CELA_1_AND_2_HR16_L3_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime, "CELA_1_AND_2_HR16_L3_FRAME_TIME_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

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

            modelBuilder.Entity<Cela3Hr16L3>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("CELA_3_HR16_L3_PK");

                entity.ToTable("CELA_3_HR16_L3");

                entity.HasIndex(e => e.FrameTime2, "CELA_3_HR16_L3_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime, "CELA_3_HR16_L3_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "CELA_3_HR16_L3_NR_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameSeq4).HasColumnName("FRAME_SEQ_4");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.FrameTime4).HasColumnName("FRAME_TIME_4");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

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

            modelBuilder.Entity<Cela5AbbBr10L2>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("CELA_5_ABB_BR10_L2_PK");

                entity.ToTable("CELA_5_ABB_BR10_L2");

                entity.HasIndex(e => e.FrameTime, "CELA_5_ABB_BR10_L2_FRAME_TIME_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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

            modelBuilder.Entity<Cela8AbbL1>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("CELA_8_ABB_L1_PK");

                entity.ToTable("CELA_8_ABB_L1");

                entity.HasIndex(e => e.FrameTime2, "CELA_8_ABB_L1_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime3, "CELA_8_ABB_L1_FRAME_TIME3_IDX");

                entity.HasIndex(e => e.FrameTime, "CELA_8_ABB_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.NrShella, e.WynikOperacji }, "CELA_8_ABB_L1_RESULT_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

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

            modelBuilder.Entity<CheckFixtureL1>(entity =>
            {
                entity.HasKey(e => new { e.NrShella, e.NrGrawerka })
                    .HasName("CHECK_FIXTURE_L1_PK");

                entity.ToTable("CHECK_FIXTURE_L1");

                entity.HasIndex(e => e.FrameTime2, "CHECK_FIXTURE_L1_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime3, "CHECK_FIXTURE_L1_FRAME_TIME3_IDX");

                entity.HasIndex(e => e.FrameTime, "CHECK_FIXTURE_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime2 }, "CHECK_FIXTURE_L1_MONITORING2_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "CHECK_FIXTURE_L1_MONITORING_IDX");

                entity.HasIndex(e => e.NrGrawerka, "CHECK_FIXTURE_L1_NR_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Unit10)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_0");

                entity.Property(e => e.Unit11)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_1");

                entity.Property(e => e.Unit12)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_2");

                entity.Property(e => e.Unit5Bot0)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_5_BOT_0");

                entity.Property(e => e.Unit5Bot1)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_5_BOT_1");

                entity.Property(e => e.Unit5Bot2)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_5_BOT_2");

                entity.Property(e => e.Unit5Top0)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_5_TOP_0");

                entity.Property(e => e.Unit5Top1)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_5_TOP_1");

                entity.Property(e => e.Unit5Top2)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_5_TOP_2");

                entity.Property(e => e.Unit6Bot0)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_6_BOT_0");

                entity.Property(e => e.Unit6Bot1)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_6_BOT_1");

                entity.Property(e => e.Unit6Bot2)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_6_BOT_2");

                entity.Property(e => e.Unit6Top0)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_6_TOP_0");

                entity.Property(e => e.Unit6Top1)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_6_TOP_1");

                entity.Property(e => e.Unit6Top2)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_6_TOP_2");

                entity.Property(e => e.UnitOkNok0)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_0")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_1")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok10)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_10")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok11)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_11")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok12)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_12")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok13)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_13")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok14)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_14")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok15)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_15")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok16)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_16")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok17)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_17")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok18)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_18")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok19)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_19")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_2")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_3")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_4")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_5")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok6)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_6")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok7)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_7")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok8)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_8")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok9)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_9")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.VariantDetGpf0)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("VARIANT_DET_GPF_0")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.VariantDetGpf1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("VARIANT_DET_GPF_1")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<EnkapsulacjaBr10L2>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("ENKAPSULACJA_BR10_L2_PK");

                entity.ToTable("ENKAPSULACJA_BR10_L2");

                entity.HasIndex(e => e.FrameTime, "ENKAPSULACJA_BR10_L2_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "ENKAPSULACJA_BR10_L2_NR_GRAWERKA_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

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

            modelBuilder.Entity<FinalGaugeBr10L2>(entity =>
            {
                entity.HasKey(e => new { e.NrShella, e.NrGrawerka })
                    .HasName("FINAL_GAUGE_BR10_L2_PK");

                entity.ToTable("FINAL_GAUGE_BR10_L2");

                entity.HasIndex(e => e.FrameTime, "FINAL_GAUGE_BR10_L2_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "FINAL_GAUGE_BR10_L2_NR_GRAWERKA_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Unit10)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_0");

                entity.Property(e => e.Unit11)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_1");

                entity.Property(e => e.Unit12)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_2");

                entity.Property(e => e.Unit13)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_3");

                entity.Property(e => e.Unit14)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_4");

                entity.Property(e => e.Unit15)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_5");

                entity.Property(e => e.Unit16)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_6");

                entity.Property(e => e.Unit17)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_7");

                entity.Property(e => e.Unit90)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_9_0");

                entity.Property(e => e.Unit91)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_9_1");

                entity.Property(e => e.Unit92)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_9_2");

                entity.Property(e => e.Unit93)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_9_3");

                entity.Property(e => e.Unit94)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_9_4");

                entity.Property(e => e.Unit95)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_9_5");

                entity.Property(e => e.UnitOkNok0)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_0")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_1")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok10)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_10")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok11)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_11")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok12)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_12")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok13)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_13")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok14)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_14")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok15)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_15")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok16)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_16")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok17)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_17")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok18)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_18")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok19)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_19")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_2")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_3")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_4")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_5")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok6)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_6")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok7)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_7")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok8)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_8")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.UnitOkNok9)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_9")
                    .HasComment("TRUE/FALSE");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<FinalGaugeHr16L3>(entity =>
            {
                entity.HasKey(e => new { e.NrShella, e.NrGrawerka })
                    .HasName("FINAL_GAUGE_HR16_L3_PK");

                entity.ToTable("FINAL_GAUGE_HR16_L3");

                entity.HasIndex(e => e.NrGrawerka, "FINAL_GAUGE_HR16_L33_NR_GRW_IDX");

                entity.HasIndex(e => e.FrameTime2, "FINAL_GAUGE_HR16_L3_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime, "FINAL_GAUGE_HR16_L3_FRAME_TIME_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

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

            modelBuilder.Entity<FinalLeaktesterHr16L3>(entity =>
            {
                entity.HasKey(e => new { e.NrShella, e.NrGrawerka })
                    .HasName("FINAL_LEAKTESER_HR16_L3_PK");

                entity.ToTable("FINAL_LEAKTESTER_HR16_L3");

                entity.HasIndex(e => e.FrameTime2, "FINAL_LEAKTESTER_HR16_L3_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime, "FINAL_LEAKTESTER_HR16_L3_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "FINAL_LEAKTESTER_HR16_L3_NR_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

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

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

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

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU")
                    .HasComment("Wynik testu NOK/OK");
            });

            modelBuilder.Entity<FinalleakTesterL1>(entity =>
            {
                entity.HasKey(e => new { e.NrShella, e.NrGrawerka })
                    .HasName("FINALLEAK_TESTER_L1_PK");

                entity.ToTable("FINALLEAK_TESTER_L1");

                entity.HasIndex(e => e.FrameTime2, "FINALLEAK_TESTER_L1_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime, "FINALLEAK_TESTER_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "FINALLEAK_TESTER_L1_NR_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

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

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

                entity.Property(e => e.WartoscPrzeplywuRurki1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WARTOSC_PRZEPLYWU_RURKI_1")
                    .HasComment("Wartość przepływu rurki 1");

                entity.Property(e => e.WartoscPrzeplywuRurki2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WARTOSC_PRZEPLYWU_RURKI_2")
                    .HasComment("Wartość przepływu rurki 2");

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

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU")
                    .HasComment("Wynik testu NOK/OK");
            });

            modelBuilder.Entity<GbdIoCalibrationBr10L2>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("GBD_IO_CALIBRATION_BR10_L2_PK");

                entity.ToTable("GBD_IO_CALIBRATION_BR10_L2");

                entity.HasIndex(e => e.FrameTime, "GBD_IO_CALIBRATION_BR10_L2_FRAME_TIME_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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

            modelBuilder.Entity<HomologationL1>(entity =>
            {
                entity.HasKey(e => new { e.NrShella, e.NrGrawerka })
                    .HasName("HOMOLOGATION_L1_PK");

                entity.ToTable("HOMOLOGATION_L1");

                entity.HasIndex(e => e.FrameTime2, "HOMOLOGATION_L1_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime, "HOMOLOGATION_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "HOMOLOGATION_L1_NR_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY")
                    .HasComment("Tryb zdalny/lokalny");

                entity.Property(e => e.Wady)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WADY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<InletPressL1>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("INLET_PRESS_L1_PK");

                entity.ToTable("INLET_PRESS_L1");

                entity.HasIndex(e => e.FrameTime2, "INLET_PRESS_L1_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime3, "INLET_PRESS_L1_FRAME_TIME3_IDX");

                entity.HasIndex(e => e.FrameTime, "INLET_PRESS_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "INLET_PRESS_L1_NR_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

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

            modelBuilder.Entity<LeakTesterBr10L2>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("LEAK_TESTER_BR10_L2_PK");

                entity.ToTable("LEAK_TESTER_BR10_L2");

                entity.HasIndex(e => e.FrameTime, "LEAK_TESTER_BR10_L2_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "LEAK_TESTER_BR10_L2_GRW_IDX");

                entity.HasIndex(e => e.GrawerkaTime, "LEAK_TESTER_BR10_L2_GRW_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka2, "LEAK_TESTER_BR10_L2_NR_GRW2_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

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

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.GrawerkaSeq).HasColumnName("GRAWERKA_SEQ");

                entity.Property(e => e.GrawerkaTime).HasColumnName("GRAWERKA_TIME");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr shella wysłany do grawerki");

                entity.Property(e => e.NrGrawerka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA_2");

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

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU")
                    .HasComment("Wynik testu NOK/OK");
            });

            modelBuilder.Entity<M260BracketChecksL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_BRACKET_CHECKS_L4_PK");

                entity.ToTable("M260_BRACKET_CHECKS_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_BRACKET_CHECKS_L4_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_BRACKET_CHECKS_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_BRACKET_CHECKS_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrEtykiety)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_ETYKIETY");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<M260ControlLoopL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_CONTROL_LOOP_L4_PK");

                entity.ToTable("M260_CONTROL_LOOP_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_CONTROL_LOOP_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_CONTROL_LOOP_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_CONTROL_LOOP_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrEtykiety)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_ETYKIETY");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NR_OPERATORA");

                entity.Property(e => e.NrPzzw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NR_PZZW");

                entity.Property(e => e.Quality)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("QUALITY");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<M260EncapsulationBodyL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_ENCAPSULATION_BODY_L4_PK");

                entity.ToTable("M260_ENCAPSULATION_BODY_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_ENCAPSULATION_BODY_L4_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_ENCAPSULATION_BODY_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_ENCAPSULATION_BODY_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

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
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<M260EncapsulationPipeL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_ENCAPSULATION_PIPE_L4_PK");

                entity.ToTable("M260_ENCAPSULATION_PIPE_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_ENCAPSULATION_PIPE_L4_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_ENCAPSULATION_PIPE_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_ENCAPSULATION_PIPE_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

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
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<M260GbdIoCalibrationL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("GBD_IO_CALIBRATION_M260_L4_PK");

                entity.ToTable("M260_GBD_IO_CALIBRATION_L4");

                entity.HasIndex(e => e.FrameTime, "GBD_IO_CALIBRATION_M260_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_GBD_IO_CALIBRATION_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI")
                    .HasComment("Data zapisu danych z PLC");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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

            modelBuilder.Entity<M260GeometryGaugeL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_GEOMETRY_GAUGE_L4_PK");

                entity.ToTable("M260_GEOMETRY_GAUGE_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_GEOMETRY_GAUGE_L4_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_GEOMETRY_GAUGE_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_GEOMETRY_GAUGE_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Unit10OkNok).HasColumnName("Unit_10_OK_NOK");

                entity.Property(e => e.Unit11OkNok).HasColumnName("Unit_11_OK_NOK");

                entity.Property(e => e.Unit12OkNok).HasColumnName("Unit_12_OK_NOK");

                entity.Property(e => e.Unit13OkNok).HasColumnName("Unit_13_OK_NOK");

                entity.Property(e => e.Unit14OkNok).HasColumnName("Unit_14_OK_NOK");

                entity.Property(e => e.Unit15OkNok).HasColumnName("Unit_15_OK_NOK");

                entity.Property(e => e.Unit16OkNok).HasColumnName("Unit_16_OK_NOK");

                entity.Property(e => e.Unit17).HasColumnName("Unit_17");

                entity.Property(e => e.Unit17OkNok).HasColumnName("Unit_17_OK_NOK");

                entity.Property(e => e.Unit1OkNok).HasColumnName("Unit_1_OK_NOK");

                entity.Property(e => e.Unit1Pin).HasColumnName("Unit_1_PIN");

                entity.Property(e => e.Unit1Shepre1).HasColumnName("Unit_1_Shepre_1");

                entity.Property(e => e.Unit1Shepre2).HasColumnName("Unit_1_Shepre_2");

                entity.Property(e => e.Unit1Shepre3).HasColumnName("Unit_1_Shepre_3");

                entity.Property(e => e.Unit1Shepre4).HasColumnName("Unit_1_Shepre_4");

                entity.Property(e => e.Unit1Shepre5).HasColumnName("Unit_1_Shepre_5");

                entity.Property(e => e.Unit1Shepre6).HasColumnName("Unit_1_Shepre_6");

                entity.Property(e => e.Unit2).HasColumnName("Unit_2");

                entity.Property(e => e.Unit2OkNok).HasColumnName("Unit_2_OK_NOK");

                entity.Property(e => e.Unit3).HasColumnName("Unit_3");

                entity.Property(e => e.Unit3OkNok).HasColumnName("Unit_3_OK_NOK");

                entity.Property(e => e.Unit4).HasColumnName("Unit_4");

                entity.Property(e => e.Unit4OkNok).HasColumnName("Unit_4_OK_NOK");

                entity.Property(e => e.Unit5).HasColumnName("Unit_5");

                entity.Property(e => e.Unit5OkNok).HasColumnName("Unit_5_OK_NOK");

                entity.Property(e => e.Unit6).HasColumnName("Unit_6");

                entity.Property(e => e.Unit6OkNok).HasColumnName("Unit_6_OK_NOK");

                entity.Property(e => e.Unit71).HasColumnName("Unit_7_1");

                entity.Property(e => e.Unit72).HasColumnName("Unit_7_2");

                entity.Property(e => e.Unit7OkNok).HasColumnName("Unit_7_OK_NOK");

                entity.Property(e => e.Unit8Bracket1).HasColumnName("Unit_8_Bracket_1");

                entity.Property(e => e.Unit8Bracket2).HasColumnName("Unit_8_Bracket_2");

                entity.Property(e => e.Unit8Flange1).HasColumnName("Unit_8_Flange_1");

                entity.Property(e => e.Unit8Flange2).HasColumnName("Unit_8_Flange_2");

                entity.Property(e => e.Unit8Flange3).HasColumnName("Unit_8_Flange_3");

                entity.Property(e => e.Unit8Flange4).HasColumnName("Unit_8_Flange_4");

                entity.Property(e => e.Unit8Flange5).HasColumnName("Unit_8_Flange_5");

                entity.Property(e => e.Unit8Flange6).HasColumnName("Unit_8_Flange_6");

                entity.Property(e => e.Unit8InnerPipe1).HasColumnName("Unit_8_InnerPipe_1");

                entity.Property(e => e.Unit8InnerPipe2).HasColumnName("Unit_8_InnerPipe_2");

                entity.Property(e => e.Unit8InnerPipe3).HasColumnName("Unit_8_InnerPipe_3");

                entity.Property(e => e.Unit8Len).HasColumnName("Unit_8_Len");

                entity.Property(e => e.Unit8OkNok).HasColumnName("Unit_8_OK_NOK");

                entity.Property(e => e.Unit8Pin1).HasColumnName("Unit_8_Pin_1");

                entity.Property(e => e.Unit8Pin2).HasColumnName("Unit_8_Pin_2");

                entity.Property(e => e.Unit8Pin4).HasColumnName("Unit_8_Pin_4");

                entity.Property(e => e.Unit9OkNok).HasColumnName("Unit_9_OK_NOK");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<M260LeakTesterAndMarkingL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_LEAK_TESTER_AND_MARKING_L4_PK");

                entity.ToTable("M260_LEAK_TESTER_AND_MARKING_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_LEAK_TESTER_AND_MARKING_L4_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_LEAK_TESTER_AND_MARKING_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_LEAK_TESTER_AND_MARKING_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

                entity.Property(e => e.Cisnienie).HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Wyciek).HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU")
                    .HasComment("Wynik testu NOK/OK");
            });

            modelBuilder.Entity<M260PreleakTesterL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_PRELEAK_TESTER_L4_PK");

                entity.ToTable("M260_PRELEAK_TESTER_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_PRELEAK_TESTER_L4_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_PRELEAK_TESTER_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_PRELEAK_TESTER_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

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
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Wyciek)
                    .HasColumnName("WYCIEK")
                    .HasComment("Wartość wycieku");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN")
                    .HasComment("Jednostka wycieku");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU")
                    .HasComment("Wynik testu NOK/OK");
            });

            modelBuilder.Entity<M260PressStationL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_PRESS_STATION_L4_PK");

                entity.ToTable("M260_PRESS_STATION_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_PRESS_STATION_L4_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_PRESS_STATION_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_PRESS_STATION_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

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
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<M260ResistanceWeldingL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_RESISTANCE_WELDING_L4_PK");

                entity.ToTable("M260_RESISTANCE_WELDING_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_RESISTANCE_WELDING_L4_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_RESISTANCE_WELDING_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_RESISTANCE_WELDING_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

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
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<M260VacuumL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_VACUUM_L4_PK");

                entity.ToTable("M260_VACUUM_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_VACUUM_L4_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_VACUUM_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_VACUUM_L4_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Vacuum1).HasColumnName("VACUUM_1");

                entity.Property(e => e.Vacuum2).HasColumnName("VACUUM_2");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<OdkurzaczBr10L2>(entity =>
            {
                entity.ToTable("ODKURZACZ_BR10_L2");

                entity.HasIndex(e => e.FrameTime, "ODKURZACZ_BR10_L2_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "ODKURZACZ_BR10_L2_NR_GRW_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI")
                    .HasComment("Data zapisu danych z PLC");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

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

            modelBuilder.Entity<OdkurzaczHr10L1>(entity =>
            {
                entity.ToTable("ODKURZACZ_HR10_L1");

                entity.HasIndex(e => e.FrameTime2, "ODKURZACZ_HR10_L1_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime, "ODKURZACZ_HR10_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "ODKURZACZ_HR10_L1_NR_GRW_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI")
                    .HasComment("Data zapisu danych z PLC");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

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

            modelBuilder.Entity<OdkurzaczHr16L3>(entity =>
            {
                entity.ToTable("ODKURZACZ_HR16_L3");

                entity.HasIndex(e => e.FrameTime2, "ODKURZACZ_HR16_L3_FRAME_TIME_2_IDX");

                entity.HasIndex(e => e.FrameTime, "ODKURZACZ_HR16_L3_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "ODKURZACZ_HR16_L3_NR_GRW_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

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

            modelBuilder.Entity<OutletPressL1>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("OUTLET_PRESS_L1_PK");

                entity.ToTable("OUTLET_PRESS_L1");

                entity.HasIndex(e => e.FrameTime2, "OUTLET_PRESS_L1_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime3, "OUTLET_PRESS_L1_FRAME_TIME3_IDX");

                entity.HasIndex(e => e.FrameTime, "OUTLET_PRESS_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "OUTLET_PRESS_L1_NR_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

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

            modelBuilder.Entity<PanelFontijneL1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PANEL_FONTIJNE_L1");

                entity.HasIndex(e => e.FrameTime, "IDX_PANEL_FONTIJNE_L1_FRAME_TIME");

                entity.HasIndex(e => e.FrameTime2, "IDX_PANEL_FONTIJNE_L1_FRAME_TIME_2");

                entity.HasIndex(e => e.FrameTime3, "IDX_PANEL_FONTIJNE_L1_FRAME_TIME_3");

                entity.HasIndex(e => e.FrameTime4, "IDX_PANEL_FONTIJNE_L1_FRAME_TIME_4");

                entity.HasIndex(e => e.ManufacturingLotTraceCode, "IDX_PANEL_FONTIJNE_L1_SHELL_NO");

                entity.Property(e => e.CisInletInsertForce)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CIS_Inlet_InsertForce");

                entity.Property(e => e.CisInletInsertSpeed)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CIS_Inlet_InsertSpeed");

                entity.Property(e => e.CisOutletInsertForce)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CIS_Outlet_InsertForce");

                entity.Property(e => e.CisOutletInsertSpeed)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CIS_Outlet_InsertSpeed");

                entity.Property(e => e.CmsMarkingOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CMS_MarkingOK_Nok");

                entity.Property(e => e.CptInletPushoutForce)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CPT_Inlet_PushoutForce");

                entity.Property(e => e.CptOutletPushoutForce)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CPT_Outlet_PushoutForce");

                entity.Property(e => e.CptPushOutOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CPT_PushOut_Ok_Nok");

                entity.Property(e => e.CsiInletSubstrateMeasureShell)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSI_Inlet_SubstrateMeasureShell");

                entity.Property(e => e.CsiOutletSubstrateMeasureShell)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSI_Outlet_SubstrateMeasureShell");

                entity.Property(e => e.CsiSubstrateMeasurementOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CSI_SubstrateMeasurement_Ok_Nok");

                entity.Property(e => e.Csm2BrickCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CSM2_BrickCode");

                entity.Property(e => e.Csm2BrickNominalDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_BrickNominalDiameter");

                entity.Property(e => e.Csm2BrickPermissibleMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_BrickPermissibleMaxDiameter");

                entity.Property(e => e.Csm2BrickPermissibleMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_BrickPermissibleMinDiameter");

                entity.Property(e => e.Csm2DateofMeasurement)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CSM2_DateofMeasurement");

                entity.Property(e => e.Csm2MeasurementOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CSM2_MeasurementOk_Nok");

                entity.Property(e => e.Csm2SubPartNo)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CSM2_SubPartNo");

                entity.Property(e => e.Csm2Zone1BrickAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_Zone1BrickAveragePerimeter");

                entity.Property(e => e.Csm2Zone1BrickMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_Zone1BrickMaxDiameter");

                entity.Property(e => e.Csm2Zone1BrickMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_Zone1BrickMinDiameter");

                entity.Property(e => e.Csm2Zone2BrickAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_Zone2BrickAveragePerimeter");

                entity.Property(e => e.Csm2Zone2BrickMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_Zone2BrickMaxDiameter");

                entity.Property(e => e.Csm2Zone2BrickMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_Zone2BrickMinDiameter");

                entity.Property(e => e.Csm2Zone3BrickAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_Zone3BrickAveragePerimeter");

                entity.Property(e => e.Csm2Zone3BrickMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_Zone3BrickMaxDiameter");

                entity.Property(e => e.Csm2Zone3BrickMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_Zone3BrickMinDiameter");

                entity.Property(e => e.Csm2Zones123BrickAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM2_Zones123BrickAveragePerimeter");

                entity.Property(e => e.CsmBrickCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CSM_BrickCode");

                entity.Property(e => e.CsmBrickNominalDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_BrickNominalDiameter");

                entity.Property(e => e.CsmBrickPermissibleMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_BrickPermissibleMaxDiameter");

                entity.Property(e => e.CsmBrickPermissibleMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_BrickPermissibleMinDiameter");

                entity.Property(e => e.CsmDateofMeasurement)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CSM_DateofMeasurement");

                entity.Property(e => e.CsmMeasurementOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CSM_MeasurementOk_Nok");

                entity.Property(e => e.CsmSubPartNo)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CSM_SubPartNo");

                entity.Property(e => e.CsmZone1BrickAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_Zone1BrickAveragePerimeter");

                entity.Property(e => e.CsmZone1BrickMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_Zone1BrickMaxDiameter");

                entity.Property(e => e.CsmZone1BrickMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_Zone1BrickMinDiameter");

                entity.Property(e => e.CsmZone2BrickAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_Zone2BrickAveragePerimeter");

                entity.Property(e => e.CsmZone2BrickMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_Zone2BrickMaxDiameter");

                entity.Property(e => e.CsmZone2BrickMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_Zone2BrickMinDiameter");

                entity.Property(e => e.CsmZone3BrickAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_Zone3BrickAveragePerimeter");

                entity.Property(e => e.CsmZone3BrickMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_Zone3BrickMaxDiameter");

                entity.Property(e => e.CsmZone3BrickMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_Zone3BrickMinDiameter");

                entity.Property(e => e.CsmZones123BrickAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CSM_Zones123BrickAveragePerimeter");

                entity.Property(e => e.CvmDateofMeasurement)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CVM_DateofMeasurement");

                entity.Property(e => e.CvmMeasurementOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CVM_MeasurementOk_Nok");

                entity.Property(e => e.CvmShellGbdnegTolerance)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_ShellGBDNegTolerance");

                entity.Property(e => e.CvmShellGbdplusTolerance)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_ShellGBDPlusTolerance");

                entity.Property(e => e.CvmShellMeasuredHeightOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CVM_ShellMeasuredHeightOk_Nok");

                entity.Property(e => e.CvmShellNominalGbd)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_ShellNominalGBD");

                entity.Property(e => e.CvmZone1ShellAverageGbd)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone1ShellAverageGBD");

                entity.Property(e => e.CvmZone1ShellAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone1ShellAveragePerimeter");

                entity.Property(e => e.CvmZone1ShellMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone1ShellMaxDiameter");

                entity.Property(e => e.CvmZone1ShellMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone1ShellMinDiameter");

                entity.Property(e => e.CvmZone2ShellAverageGbd)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone2ShellAverageGBD");

                entity.Property(e => e.CvmZone2ShellAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone2ShellAveragePerimeter");

                entity.Property(e => e.CvmZone2ShellMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone2ShellMaxDiameter");

                entity.Property(e => e.CvmZone2ShellMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone2ShellMinDiameter");

                entity.Property(e => e.CvmZone3ShellAverageGbd)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone3ShellAverageGBD");

                entity.Property(e => e.CvmZone3ShellAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone3ShellAveragePerimeter");

                entity.Property(e => e.CvmZone3ShellMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone3ShellMaxDiameter");

                entity.Property(e => e.CvmZone3ShellMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone3ShellMinDiameter");

                entity.Property(e => e.CvmZone4ShellAverageGbd)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone4ShellAverageGBD");

                entity.Property(e => e.CvmZone4ShellAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone4ShellAveragePerimeter");

                entity.Property(e => e.CvmZone4ShellMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone4ShellMaxDiameter");

                entity.Property(e => e.CvmZone4ShellMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone4ShellMinDiameter");

                entity.Property(e => e.CvmZone5ShellAverageGbd)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone5ShellAverageGBD");

                entity.Property(e => e.CvmZone5ShellAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone5ShellAveragePerimeter");

                entity.Property(e => e.CvmZone5ShellMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone5ShellMaxDiameter");

                entity.Property(e => e.CvmZone5ShellMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone5ShellMinDiameter");

                entity.Property(e => e.CvmZone6ShellAverageGbd)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone6ShellAverageGBD");

                entity.Property(e => e.CvmZone6ShellAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone6ShellAveragePerimeter");

                entity.Property(e => e.CvmZone6ShellMaxDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone6ShellMaxDiameter");

                entity.Property(e => e.CvmZone6ShellMinDiameter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zone6ShellMinDiameter");

                entity.Property(e => e.CvmZones123ShellAverageGbd)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zones123ShellAverageGBD");

                entity.Property(e => e.CvmZones123ShellAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zones123ShellAveragePerimeter");

                entity.Property(e => e.CvmZones456ShellAverageGbd)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zones456ShellAverageGBD");

                entity.Property(e => e.CvmZones456ShellAveragePerimeter)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CVM_Zones456ShellAveragePerimeter");

                entity.Property(e => e.Cws2MatActualWeight)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CWS2_MatActualWeight");

                entity.Property(e => e.Cws2MatArea)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CWS2_MatArea");

                entity.Property(e => e.Cws2MatBachCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CWS2_MatBachCode");

                entity.Property(e => e.Cws2MatBoxCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CWS2_MatBoxCode");

                entity.Property(e => e.Cws2MatCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CWS2_MatCode");

                entity.Property(e => e.Cws2MatNominalWeight)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CWS2_MatNominalWeight");

                entity.Property(e => e.Cws2MatOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CWS2_MatOk_Nok");

                entity.Property(e => e.Cws2MatPartNo)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CWS2_MatPartNo");

                entity.Property(e => e.Cws2MatPermissibleMaxWeight)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CWS2_MatPermissibleMaxWeight");

                entity.Property(e => e.Cws2MatPermissibleMinWeight)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CWS2_MatPermissibleMinWeight");

                entity.Property(e => e.CwsMatActualWeight)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CWS_MatActualWeight");

                entity.Property(e => e.CwsMatArea)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CWS_MatArea");

                entity.Property(e => e.CwsMatBachCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CWS_MatBachCode");

                entity.Property(e => e.CwsMatBoxCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CWS_MatBoxCode");

                entity.Property(e => e.CwsMatCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CWS_MatCode");

                entity.Property(e => e.CwsMatNominalWeight)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CWS_MatNominalWeight");

                entity.Property(e => e.CwsMatOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CWS_MatOk_Nok");

                entity.Property(e => e.CwsMatPartNo)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CWS_MatPartNo");

                entity.Property(e => e.CwsMatPermissibleMaxWeight)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CWS_MatPermissibleMaxWeight");

                entity.Property(e => e.CwsMatPermissibleMinWeight)
                    .HasColumnType("decimal(20, 6)")
                    .HasColumnName("CWS_MatPermissibleMinWeight");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameSeq4).HasColumnName("FRAME_SEQ_4");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.FrameTime4).HasColumnName("FRAME_TIME_4");

                entity.Property(e => e.GmpartNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("GMPartNumber");

                entity.Property(e => e.ManufacturingLotTraceCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturingLotTraceCodeOutlet)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ManufacturingLotTraceCode_Outlet");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

                entity.Property(e => e.OempartNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("OEMPartNumber");

                entity.Property(e => e.ShellWallThickness).HasColumnType("decimal(12, 6)");
            });

            modelBuilder.Entity<PetlaKontrolnaBr10L2>(entity =>
            {
                entity.ToTable("PETLA_KONTROLNA_BR10_L2");

                entity.HasIndex(e => e.FrameTime, "PETLA_KONTROLNA_BR10_L2_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "PETLA_KONTROLNA_BR10_L2_MONITORING_IDX");

                entity.HasIndex(e => e.NrGrawerka, "PETLA_KONTROLNA_BR10_L2_NR_GRAWERKA_IDX");

                entity.HasIndex(e => e.WynikOperacji, "PETLA_KONTROLNA_BR10_L2_RESULT_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(50)
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

            modelBuilder.Entity<PetlaKontrolnaHr10L1>(entity =>
            {
                entity.ToTable("PETLA_KONTROLNA_HR10_L1");

                entity.HasIndex(e => e.FrameTime2, "PETLA_KONTROLNA_HR10_L1_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime, "PETLA_KONTROLNA_HR10_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "PETLA_KONTROLNA_HR10_L1_NR_GRAWERKA_IDX");

                entity.HasIndex(e => e.WynikOperacji, "PETLA_KONTROLNA_HR10_L1_RESULT_IDX");

                entity.HasIndex(e => new { e.FrameTime2, e.NrLinii, e.WynikOperacji }, "[PETLA_KONTROLNA_HR10_L1_MONITORING2_IDX");

                entity.HasIndex(e => new { e.FrameTime, e.NrLinii, e.WynikOperacji }, "[PETLA_KONTROLNA_HR10_L1_MONITORING_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(50)
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

            modelBuilder.Entity<PetlaKontrolnaHr16L3>(entity =>
            {
                entity.ToTable("PETLA_KONTROLNA_HR16_L3");

                entity.HasIndex(e => e.FrameTime2, "PETLA_KONTROLNA_HR16_L3_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime, "PETLA_KONTROLNA_HR16_L3_FRAME_TIME_IDX");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "PETLA_KONTROLNA_HR16_L3_MONITORING_IDX");

                entity.HasIndex(e => e.NrGrawerka, "PETLA_KONTROLNA_HR16_L3_NR_GRW_IDX");

                entity.HasIndex(e => e.WynikOperacji, "PETLA_KONTROLNA_HR16_L3_RESULT_IDX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(50)
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

            modelBuilder.Entity<PreleakTesterL1>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("PRELEAK_TESTER_L1_PK");

                entity.ToTable("PRELEAK_TESTER_L1");

                entity.HasIndex(e => e.FrameTime2, "PRELEAK_TESTER_L1_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime3, "PRELEAK_TESTER_L1_FRAME_TIME3_IDX");

                entity.HasIndex(e => e.FrameTime, "PRELEAK_TESTER_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.GrawerkaTime, "PRELEAK_TESTER_L1_GRW_TIME2_IDX");

                entity.HasIndex(e => e.GrawerkaTime3, "PRELEAK_TESTER_L1_GRW_TIME3_IDX");

                entity.HasIndex(e => e.GrawerkaTime, "PRELEAK_TESTER_L1_GRW_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka2, "PRELEAK_TESTER_L1_NR_GRW2_IDX");

                entity.HasIndex(e => e.NrGrawerka, "PRELEAK_TESTER_L1_NR_GRW_IDX");

                entity.HasIndex(e => e.NrShella, "PRELEAK_TESTER_L1_SHELL_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

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

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.GrawerkaSeq).HasColumnName("GRAWERKA_SEQ");

                entity.Property(e => e.GrawerkaSeq2).HasColumnName("GRAWERKA_SEQ_2");

                entity.Property(e => e.GrawerkaSeq3).HasColumnName("GRAWERKA_SEQ_3");

                entity.Property(e => e.GrawerkaTime).HasColumnName("GRAWERKA_TIME");

                entity.Property(e => e.GrawerkaTime2).HasColumnName("GRAWERKA_TIME_2");

                entity.Property(e => e.GrawerkaTime3).HasColumnName("GRAWERKA_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr shella wysłany do grawerki");

                entity.Property(e => e.NrGrawerka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA_2");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

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

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<PreleaktesterHr16L3>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("PRELEAKTESER_HR16_L3_PK");

                entity.ToTable("PRELEAKTESTER_HR16_L3");

                entity.HasIndex(e => e.FrameTime2, "PRELEAKTESTER_HR16_L3_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime, "PRELEAKTESTER_HR16_L3_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "PRELEAKTESTER_HR16_L3_NR_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella ze skanera");

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

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.GrawerkaSeq).HasColumnName("GRAWERKA_SEQ");

                entity.Property(e => e.GrawerkaSeq2).HasColumnName("GRAWERKA_SEQ_2");

                entity.Property(e => e.GrawerkaSeq3).HasColumnName("GRAWERKA_SEQ_3");

                entity.Property(e => e.GrawerkaTime).HasColumnName("GRAWERKA_TIME");

                entity.Property(e => e.GrawerkaTime2).HasColumnName("GRAWERKA_TIME_2");

                entity.Property(e => e.GrawerkaTime3).HasColumnName("GRAWERKA_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr shella wysłany do grawerki");

                entity.Property(e => e.NrGrawerka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA_2");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

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

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<ReworkBr10L2>(entity =>
            {
                entity.ToTable("REWORK_BR10_L2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdOperatora)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_OPERATORA");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODEL");

                entity.Property(e => e.NrKodu)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KODU")
                    .HasComment("Nr kodu");

                entity.Property(e => e.WadaJakosciowa)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WADA_JAKOSCIOWA")
                    .HasComment("Wada jakosciowa");
            });

            modelBuilder.Entity<ReworkHr10L1>(entity =>
            {
                entity.ToTable("REWORK_HR10_L1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdOperatora)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_OPERATORA");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODEL");

                entity.Property(e => e.NrKodu)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KODU")
                    .HasComment("Nr kodu");

                entity.Property(e => e.WadaJakosciowa)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WADA_JAKOSCIOWA")
                    .HasComment("Wada jakosciowa");
            });

            modelBuilder.Entity<ReworkHr16L3>(entity =>
            {
                entity.ToTable("REWORK_HR16_L3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdOperatora)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_OPERATORA");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MODEL");

                entity.Property(e => e.NrKodu)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KODU")
                    .HasComment("Nr kodu");

                entity.Property(e => e.WadaJakosciowa)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WADA_JAKOSCIOWA")
                    .HasComment("Wada jakosciowa");
            });

            modelBuilder.Entity<ReworkOslonHr10L1>(entity =>
            {
                entity.ToTable("REWORK_OSLON_HR10_L1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI")
                    .HasComment("Data zapisu danych z PLC");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerkaKodDet)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA_KOD_DET")
                    .HasComment("Nr wygrawerowany kod DET");

                entity.Property(e => e.NrGrawerkaKodGpf)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA_KOD_GPF")
                    .HasComment("Nr wygrawerowany kod GPF");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");
            });

            modelBuilder.Entity<TorqueScrewdriverL1>(entity =>
            {
                entity.HasKey(e => new { e.NrShella, e.NrGrawerka })
                    .HasName("TORQUE_SCREWDRIVER_L1_PK");

                entity.ToTable("TORQUE_SCREWDRIVER_L1");

                entity.HasIndex(e => e.FrameTime2, "TORQUE_SCREWDRIVER_L1_FRAME_TIME2_IDX");

                entity.HasIndex(e => e.FrameTime3, "TORQUE_SCREWDRIVER_L1_FRAME_TIME3_IDX");

                entity.HasIndex(e => e.FrameTime, "TORQUE_SCREWDRIVER_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "TORQUE_SCREWDRIVER_L1_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.AngleNakretka1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ANGLE_NAKRETKA1")
                    .HasComment("Położenie kątowe - Nakrętka 1");

                entity.Property(e => e.AngleNakretka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ANGLE_NAKRETKA2")
                    .HasComment("Położenie kątowe - Nakrętka 2");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

                entity.Property(e => e.TorqueNakretka1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_NAKRETKA1")
                    .HasComment("Moment obrotowy - Nakretka 1");

                entity.Property(e => e.TorqueNakretka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_NAKRETKA2")
                    .HasComment("Moment obrotowy - Nakretka 2");

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

            modelBuilder.Entity<VCela1And2Hr16L3Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CELA_1_AND_2_HR16_L3_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VCela3Hr16L3Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CELA_3_HR16_L3_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.FrameTime4).HasColumnName("FRAME_TIME_4");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VCela5AbbBr10L2Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CELA_5_ABB_BR10_L2_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VCela8AbbL1Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CELA_8_ABB_L1_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VCheckFixtureL1Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CHECK_FIXTURE_L1_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VEnkapsulacjaBr10L2Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ENKAPSULACJA_BR10_L2_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VFinalGaugeBr10L2Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FINAL_GAUGE_BR10_L2_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VFinalGaugeHr16L3Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FINAL_GAUGE_HR16_L3_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VFinalLeaktesterHr16L3Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FINAL_LEAKTESTER_HR16_L3_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<VFinalleakTesterMonitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FINALLEAK_TESTER_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<VHomologationL1Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HOMOLOGATION_L1_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VInletPressL1Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_INLET_PRESS_L1_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VLeakTesterBr10L2Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_LEAK_TESTER_BR10_L2_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrGrawerka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA_2");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<VOdkurzaczBr10L2Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ODKURZACZ_BR10_L2_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VOdkurzaczHr10L1Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ODKURZACZ_HR10_L1_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VOdkurzaczHr16L3Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ODKURZACZ_HR16_L3_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VOutletPressL1Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_OUTLET_PRESS_L1_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VPetlaKontrolnaBr10L2Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PETLA_KONTROLNA_BR10_L2_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrPaleta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_PALETA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VPetlaKontrolnaHr10L1Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PETLA_KONTROLNA_HR10_L1_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrPaleta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_PALETA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VPetlaKontrolnaHr16L3Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PETLA_KONTROLNA_HR16_L3_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrPaleta)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_PALETA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VPreleakTesterMonitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PRELEAK_TESTER_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrGrawerka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA_2");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<VPreleaktesterHr16L3Monitoirng>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PRELEAKTESTER_HR16_L3_MONITOIRNG");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrGrawerka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA_2");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<VTorqueScrewdriverL1Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TORQUE_SCREWDRIVER_L1_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VWkretakL2Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WKRETAK_L2_MONITORING");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<WiremeshBr10L2>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("WIREMECH_BR10_L2_PK");

                entity.ToTable("WIREMESH_BR10_L2");

                entity.HasIndex(e => e.FrameTime, "WIREMESH_BR10_L2_FRAME_TIME_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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

            modelBuilder.Entity<WkretakBr10L2>(entity =>
            {
                entity.HasKey(e => new { e.NrShella, e.NrGrawerka })
                    .HasName("WKRETAK_BR10_L2_PK");

                entity.ToTable("WKRETAK_BR10_L2");

                entity.HasIndex(e => e.FrameTime, "WKRETAK_BR10_L2_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "WKRETAK_BR10_L2_NR_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA")
                    .HasComment("Nr shella");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA")
                    .HasComment("Nr wygrawerowany");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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
