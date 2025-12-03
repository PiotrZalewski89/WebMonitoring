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
        public virtual DbSet<Hr12ccCell3L7> Hr12ccCell3L7s { get; set; }
        public virtual DbSet<Hr12ccCell4L7> Hr12ccCell4L7s { get; set; }
        public virtual DbSet<Hr12ccCheckFixtureL7> Hr12ccCheckFixtureL7s { get; set; }
        public virtual DbSet<Hr12ccControlLoopL7> Hr12ccControlLoopL7s { get; set; }
        public virtual DbSet<Hr12ccDeflectorGaugeL7> Hr12ccDeflectorGaugeL7s { get; set; }
        public virtual DbSet<Hr12ccDeflectorL7> Hr12ccDeflectorL7s { get; set; }
        public virtual DbSet<Hr12ccFinalleakTesterL7> Hr12ccFinalleakTesterL7s { get; set; }
        public virtual DbSet<Hr12ccHomologationL7> Hr12ccHomologationL7s { get; set; }
        public virtual DbSet<Hr12ccOutletPressL7> Hr12ccOutletPressL7s { get; set; }
        public virtual DbSet<Hr12ccPreleakTesterL7> Hr12ccPreleakTesterL7s { get; set; }
        public virtual DbSet<Hr12ccSizerGbdInletL7> Hr12ccSizerGbdInletL7s { get; set; }
        public virtual DbSet<Hr12ccSizerGbdOutletL7> Hr12ccSizerGbdOutletL7s { get; set; }
        public virtual DbSet<Hr12ccTorqueScrewdriverL7> Hr12ccTorqueScrewdriverL7s { get; set; }
        public virtual DbSet<Hr12ccVacuumCleanerL7> Hr12ccVacuumCleanerL7s { get; set; }
        public virtual DbSet<Hr12ccWeldingCellInletBasicClamshellOp3L7> Hr12ccWeldingCellInletBasicClamshellOp3L7s { get; set; }
        public virtual DbSet<Hr12ccWeldingCellInletOutletBasicMidclamshellL7> Hr12ccWeldingCellInletOutletBasicMidclamshellL7s { get; set; }
        public virtual DbSet<Hr12ccWeldingCellIntletBasicMidclamshellOp8L7> Hr12ccWeldingCellIntletBasicMidclamshellOp8L7s { get; set; }
        public virtual DbSet<Hr12ccWeldingCellMidclamshellOp7L7> Hr12ccWeldingCellMidclamshellOp7L7s { get; set; }
        public virtual DbSet<Hr12ccWeldingCellOutletBasicClamshellOp6L7> Hr12ccWeldingCellOutletBasicClamshellOp6L7s { get; set; }
        public virtual DbSet<Hr12ufControlLoopL6> Hr12ufControlLoopL6s { get; set; }
        public virtual DbSet<Hr12ufFinalGaugeL6> Hr12ufFinalGaugeL6s { get; set; }
        public virtual DbSet<Hr12ufLeaktesterL6> Hr12ufLeaktesterL6s { get; set; }
        public virtual DbSet<Hr12ufMarkingL6> Hr12ufMarkingL6s { get; set; }
        public virtual DbSet<Hr12ufReworkL6> Hr12ufReworkL6s { get; set; }
        public virtual DbSet<Hr12ufSizerInletL6> Hr12ufSizerInletL6s { get; set; }
        public virtual DbSet<Hr12ufSizerOutletL6> Hr12ufSizerOutletL6s { get; set; }
        public virtual DbSet<Hr12ufVacuumL6> Hr12ufVacuumL6s { get; set; }
        public virtual DbSet<Hr12ufWeldingCellL6> Hr12ufWeldingCellL6s { get; set; }
        public virtual DbSet<Hr18ControlLoopL5> Hr18ControlLoopL5s { get; set; }
        public virtual DbSet<Hr18FinalGaugeL5> Hr18FinalGaugeL5s { get; set; }
        public virtual DbSet<Hr18LeaktesterL5> Hr18LeaktesterL5s { get; set; }
        public virtual DbSet<Hr18VacuumL5> Hr18VacuumL5s { get; set; }
        public virtual DbSet<Hr18WeldingCellL5> Hr18WeldingCellL5s { get; set; }
        public virtual DbSet<InletPressL1> InletPressL1s { get; set; }
        public virtual DbSet<LeakTesterBr10L2> LeakTesterBr10L2s { get; set; }
        public virtual DbSet<M260BracketChecksL4> M260BracketChecksL4s { get; set; }
        public virtual DbSet<M260ControlLoopL4> M260ControlLoopL4s { get; set; }
        public virtual DbSet<M260EncapsulationBodyL4> M260EncapsulationBodyL4s { get; set; }
        public virtual DbSet<M260EncapsulationPipeL4> M260EncapsulationPipeL4s { get; set; }
        public virtual DbSet<M260GbdIoCalibrationL4> M260GbdIoCalibrationL4s { get; set; }
        public virtual DbSet<M260GeometryGaugeL4> M260GeometryGaugeL4s { get; set; }
        public virtual DbSet<M260LaserMarkingL4> M260LaserMarkingL4s { get; set; }
        public virtual DbSet<M260LeakTesterAndMarkingL4> M260LeakTesterAndMarkingL4s { get; set; }
        public virtual DbSet<M260PreleakTesterL4> M260PreleakTesterL4s { get; set; }
        public virtual DbSet<M260PressStationL4> M260PressStationL4s { get; set; }
        public virtual DbSet<M260ReprintL4> M260ReprintL4s { get; set; }
        public virtual DbSet<M260ResistanceWeldingL4> M260ResistanceWeldingL4s { get; set; }
        public virtual DbSet<M260ReworkOslonyL4> M260ReworkOslonyL4s { get; set; }
        public virtual DbSet<M260VacuumL4> M260VacuumL4s { get; set; }
        public virtual DbSet<M260WeldingCell1L4> M260WeldingCell1L4s { get; set; }
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
        public virtual DbSet<ReworkHr12ccL7> ReworkHr12ccL7s { get; set; }
        public virtual DbSet<ReworkHr16L3> ReworkHr16L3s { get; set; }
        public virtual DbSet<ReworkM260aL4> ReworkM260aL4s { get; set; }
        public virtual DbSet<ReworkOslonHr10L1> ReworkOslonHr10L1s { get; set; }
        public virtual DbSet<ShellLineDimecoL0> ShellLineDimecoL0s { get; set; }
        public virtual DbSet<ShellLineWeilL0> ShellLineWeilL0s { get; set; }
        public virtual DbSet<TorqueScrewdriverL1> TorqueScrewdriverL1s { get; set; }
        public virtual DbSet<VCela1And2Hr16L3All> VCela1And2Hr16L3Alls { get; set; }
        public virtual DbSet<VCela1And2Hr16L3Monitoring> VCela1And2Hr16L3Monitorings { get; set; }
        public virtual DbSet<VCela3Hr16L3All> VCela3Hr16L3Alls { get; set; }
        public virtual DbSet<VCela3Hr16L3Monitoring> VCela3Hr16L3Monitorings { get; set; }
        public virtual DbSet<VCela5AbbBr10L2All> VCela5AbbBr10L2Alls { get; set; }
        public virtual DbSet<VCela5AbbBr10L2Monitoring> VCela5AbbBr10L2Monitorings { get; set; }
        public virtual DbSet<VCela8AbbL1All> VCela8AbbL1Alls { get; set; }
        public virtual DbSet<VCela8AbbL1Monitoring> VCela8AbbL1Monitorings { get; set; }
        public virtual DbSet<VCheckFixtureL1All> VCheckFixtureL1Alls { get; set; }
        public virtual DbSet<VCheckFixtureL1Monitoring> VCheckFixtureL1Monitorings { get; set; }
        public virtual DbSet<VEnkapsulacjaBr10L2All> VEnkapsulacjaBr10L2Alls { get; set; }
        public virtual DbSet<VEnkapsulacjaBr10L2Monitoring> VEnkapsulacjaBr10L2Monitorings { get; set; }
        public virtual DbSet<VFinalGaugeBr10L2All> VFinalGaugeBr10L2Alls { get; set; }
        public virtual DbSet<VFinalGaugeBr10L2Monitoring> VFinalGaugeBr10L2Monitorings { get; set; }
        public virtual DbSet<VFinalGaugeHr16L3All> VFinalGaugeHr16L3Alls { get; set; }
        public virtual DbSet<VFinalGaugeHr16L3Monitoring> VFinalGaugeHr16L3Monitorings { get; set; }
        public virtual DbSet<VFinalLeaktesterHr16L3All> VFinalLeaktesterHr16L3Alls { get; set; }
        public virtual DbSet<VFinalLeaktesterHr16L3Monitoring> VFinalLeaktesterHr16L3Monitorings { get; set; }
        public virtual DbSet<VFinalleakTesterL1All> VFinalleakTesterL1Alls { get; set; }
        public virtual DbSet<VFinalleakTesterMonitoring> VFinalleakTesterMonitorings { get; set; }
        public virtual DbSet<VGbdIoCalibrationBr10L2All> VGbdIoCalibrationBr10L2Alls { get; set; }
        public virtual DbSet<VHomologationL1All> VHomologationL1Alls { get; set; }
        public virtual DbSet<VHomologationL1Monitoring> VHomologationL1Monitorings { get; set; }
        public virtual DbSet<VHr12ccCell3L7All> VHr12ccCell3L7Alls { get; set; }
        public virtual DbSet<VHr12ccCell4L7All> VHr12ccCell4L7Alls { get; set; }
        public virtual DbSet<VHr12ccCheckFixtureL7All> VHr12ccCheckFixtureL7Alls { get; set; }
        public virtual DbSet<VHr12ccControlLoopL7All> VHr12ccControlLoopL7Alls { get; set; }
        public virtual DbSet<VHr12ccDeflectorGaugeL7All> VHr12ccDeflectorGaugeL7Alls { get; set; }
        public virtual DbSet<VHr12ccDeflectorL7All> VHr12ccDeflectorL7Alls { get; set; }
        public virtual DbSet<VHr12ccFinalleakTesterL7All> VHr12ccFinalleakTesterL7Alls { get; set; }
        public virtual DbSet<VHr12ccHomologationL7All> VHr12ccHomologationL7Alls { get; set; }
        public virtual DbSet<VHr12ccOutletPressL7All> VHr12ccOutletPressL7Alls { get; set; }
        public virtual DbSet<VHr12ccPreleakTesterL7All> VHr12ccPreleakTesterL7Alls { get; set; }
        public virtual DbSet<VHr12ccSizerGbdInletL7All> VHr12ccSizerGbdInletL7Alls { get; set; }
        public virtual DbSet<VHr12ccSizerGbdOutletL7All> VHr12ccSizerGbdOutletL7Alls { get; set; }
        public virtual DbSet<VHr12ccTorqueScrewdriverL7All> VHr12ccTorqueScrewdriverL7Alls { get; set; }
        public virtual DbSet<VHr12ccVacuumCleanerL7All> VHr12ccVacuumCleanerL7Alls { get; set; }
        public virtual DbSet<VHr12ccWeldingCellInletBasicClamshellOp3L7All> VHr12ccWeldingCellInletBasicClamshellOp3L7Alls { get; set; }
        public virtual DbSet<VHr12ccWeldingCellInletOutletBasicMidclamshellL7All> VHr12ccWeldingCellInletOutletBasicMidclamshellL7Alls { get; set; }
        public virtual DbSet<VHr12ccWeldingCellIntletBasicMidclamshellOp8L7All> VHr12ccWeldingCellIntletBasicMidclamshellOp8L7Alls { get; set; }
        public virtual DbSet<VHr12ccWeldingCellMidclamshellOp7L7All> VHr12ccWeldingCellMidclamshellOp7L7Alls { get; set; }
        public virtual DbSet<VHr12ccWeldingCellOutletBasicClamshellOp6L7All> VHr12ccWeldingCellOutletBasicClamshellOp6L7Alls { get; set; }
        public virtual DbSet<VHr12ufControlLoopL6All> VHr12ufControlLoopL6Alls { get; set; }
        public virtual DbSet<VHr12ufFinalGaugeL6All> VHr12ufFinalGaugeL6Alls { get; set; }
        public virtual DbSet<VHr12ufLeaktesterL6All> VHr12ufLeaktesterL6Alls { get; set; }
        public virtual DbSet<VHr12ufMarkingL6All> VHr12ufMarkingL6Alls { get; set; }
        public virtual DbSet<VHr12ufSizerInletL6All> VHr12ufSizerInletL6Alls { get; set; }
        public virtual DbSet<VHr12ufSizerOutletL6All> VHr12ufSizerOutletL6Alls { get; set; }
        public virtual DbSet<VHr12ufVacuumL6All> VHr12ufVacuumL6Alls { get; set; }
        public virtual DbSet<VHr12ufWeldingCellL6All> VHr12ufWeldingCellL6Alls { get; set; }
        public virtual DbSet<VHr18ControlLoopL5All> VHr18ControlLoopL5Alls { get; set; }
        public virtual DbSet<VHr18FinalGaugeL5All> VHr18FinalGaugeL5Alls { get; set; }
        public virtual DbSet<VHr18LeaktesterL5All> VHr18LeaktesterL5Alls { get; set; }
        public virtual DbSet<VHr18VacuumL5All> VHr18VacuumL5Alls { get; set; }
        public virtual DbSet<VHr18WeldingCellL5All> VHr18WeldingCellL5Alls { get; set; }
        public virtual DbSet<VInletPressL1All> VInletPressL1Alls { get; set; }
        public virtual DbSet<VInletPressL1Monitoring> VInletPressL1Monitorings { get; set; }
        public virtual DbSet<VLeakTesterBr10L2All> VLeakTesterBr10L2Alls { get; set; }
        public virtual DbSet<VLeakTesterBr10L2Monitoring> VLeakTesterBr10L2Monitorings { get; set; }
        public virtual DbSet<VM260BracketChecksL4All> VM260BracketChecksL4Alls { get; set; }
        public virtual DbSet<VM260ControlLoopL4All> VM260ControlLoopL4Alls { get; set; }
        public virtual DbSet<VM260EncapsulationBodyL4All> VM260EncapsulationBodyL4Alls { get; set; }
        public virtual DbSet<VM260EncapsulationPipeL4All> VM260EncapsulationPipeL4Alls { get; set; }
        public virtual DbSet<VM260GbdIoCalibrationL4All> VM260GbdIoCalibrationL4Alls { get; set; }
        public virtual DbSet<VM260GeometryGaugeL4All> VM260GeometryGaugeL4Alls { get; set; }
        public virtual DbSet<VM260LeakTesterAndMarkingL4All> VM260LeakTesterAndMarkingL4Alls { get; set; }
        public virtual DbSet<VM260PreleakTesterL4All> VM260PreleakTesterL4Alls { get; set; }
        public virtual DbSet<VM260PressStationL4All> VM260PressStationL4Alls { get; set; }
        public virtual DbSet<VM260ResistanceWeldingL4All> VM260ResistanceWeldingL4Alls { get; set; }
        public virtual DbSet<VM260VacuumL4All> VM260VacuumL4Alls { get; set; }
        public virtual DbSet<VM260WeldingCell1L4All> VM260WeldingCell1L4Alls { get; set; }
        public virtual DbSet<VOdkurzaczBr10L2Monitoring> VOdkurzaczBr10L2Monitorings { get; set; }
        public virtual DbSet<VOdkurzaczHr10L1Monitoring> VOdkurzaczHr10L1Monitorings { get; set; }
        public virtual DbSet<VOdkurzaczHr16L3Monitoring> VOdkurzaczHr16L3Monitorings { get; set; }
        public virtual DbSet<VOutletPressL1All> VOutletPressL1Alls { get; set; }
        public virtual DbSet<VOutletPressL1Monitoring> VOutletPressL1Monitorings { get; set; }
        public virtual DbSet<VPetlaKontrolnaBr10L2Monitoring> VPetlaKontrolnaBr10L2Monitorings { get; set; }
        public virtual DbSet<VPetlaKontrolnaHr10L1Monitoring> VPetlaKontrolnaHr10L1Monitorings { get; set; }
        public virtual DbSet<VPetlaKontrolnaHr16L3Monitoring> VPetlaKontrolnaHr16L3Monitorings { get; set; }
        public virtual DbSet<VPreleakTesterL1All> VPreleakTesterL1Alls { get; set; }
        public virtual DbSet<VPreleakTesterMonitoring> VPreleakTesterMonitorings { get; set; }
        public virtual DbSet<VPreleaktesterHr16L3All> VPreleaktesterHr16L3Alls { get; set; }
        public virtual DbSet<VPreleaktesterHr16L3Monitoirng> VPreleaktesterHr16L3Monitoirngs { get; set; }
        public virtual DbSet<VStf> VStfs { get; set; }
        public virtual DbSet<VStf3> VStf3s { get; set; }
        public virtual DbSet<VStf4> VStf4s { get; set; }
        public virtual DbSet<VStf5> VStf5s { get; set; }
        public virtual DbSet<VStf6> VStf6s { get; set; }
        public virtual DbSet<VTorqueScrewdriverL1All> VTorqueScrewdriverL1Alls { get; set; }
        public virtual DbSet<VTorqueScrewdriverL1Monitoring> VTorqueScrewdriverL1Monitorings { get; set; }
        public virtual DbSet<VWiremeshBr10L2All> VWiremeshBr10L2Alls { get; set; }
        public virtual DbSet<VWkretakBr10L2All> VWkretakBr10L2Alls { get; set; }
        public virtual DbSet<VWkretakL2Monitoring> VWkretakL2Monitorings { get; set; }
        public virtual DbSet<WiremeshBr10L2> WiremeshBr10L2s { get; set; }
        public virtual DbSet<WkretakBr10L2> WkretakBr10L2s { get; set; }
        public virtual DbSet<ZgrzewaniePatchL1> ZgrzewaniePatchL1s { get; set; }

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

            modelBuilder.Entity<Hr12ccCell3L7>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("HR12CC_CELL_3_L7_PK");

                entity.ToTable("HR12CC_CELL_3_L7");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrClamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_CLAMSHELL");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccCell4L7>(entity =>
            {
                entity.HasKey(e => e.NrShellaOutlet)
                    .HasName("HR12CC_CELL_4_L7_PK");

                entity.ToTable("HR12CC_CELL_4_L7");

                entity.Property(e => e.NrShellaOutlet)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_OUTLET");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrClamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_CLAMSHELL");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.NrShellaInlet)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_INLET");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccCheckFixtureL7>(entity =>
            {
                entity.HasKey(e => e.NrGrawerka)
                    .HasName("HR12CC_CHECK_FIXTURE_L7_PK");

                entity.ToTable("HR12CC_CHECK_FIXTURE_L7");

                entity.HasIndex(e => e.FrameTime, "HR12CC_CHECK_FIXTURE_L7_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "HR12CC_CHECK_FIXTURE_L7_NR_GRW_IDX");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

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

                entity.Property(e => e.Unit18)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_8");

                entity.Property(e => e.Unit19)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_9");

                entity.Property(e => e.UnitOkNok10)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_10");

                entity.Property(e => e.UnitOkNok11)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_11");

                entity.Property(e => e.UnitOkNok12)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_12");

                entity.Property(e => e.UnitOkNok2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_2");

                entity.Property(e => e.UnitOkNok3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_3");

                entity.Property(e => e.UnitOkNok4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_4");

                entity.Property(e => e.UnitOkNok5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_5");

                entity.Property(e => e.UnitOkNok6)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_6");

                entity.Property(e => e.UnitOkNok7)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_7");

                entity.Property(e => e.UnitOkNok8)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_8");

                entity.Property(e => e.UnitOkNok9)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_9");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccControlLoopL7>(entity =>
            {
                entity.HasKey(e => e.NrKatalizatora)
                    .HasName("HR12CC_CONTROL_LOOP_L7_PK");

                entity.ToTable("HR12CC_CONTROL_LOOP_L7");

                entity.Property(e => e.NrKatalizatora)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

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

            modelBuilder.Entity<Hr12ccDeflectorGaugeL7>(entity =>
            {
                entity.HasKey(e => e.NrGrawerka)
                    .HasName("HR12CC_DEFLECTOR_GAUGE_L7_PK");

                entity.ToTable("HR12CC_DEFLECTOR_GAUGE_L7");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Unit10Nc1).HasColumnName("UNIT_10_NC1");

                entity.Property(e => e.Unit10Nc2).HasColumnName("UNIT_10_NC2");

                entity.Property(e => e.Unit10Nc3).HasColumnName("UNIT_10_NC3");

                entity.Property(e => e.Unit10Nc4).HasColumnName("UNIT_10_NC4");

                entity.Property(e => e.Unit11Nc1).HasColumnName("UNIT_11_NC1");

                entity.Property(e => e.Unit12Nc1).HasColumnName("UNIT_12_NC1");

                entity.Property(e => e.Unit4).HasColumnName("UNIT_4");

                entity.Property(e => e.Unit6Nc1).HasColumnName("UNIT_6_NC1");

                entity.Property(e => e.Unit6Nc2).HasColumnName("UNIT_6_NC2");

                entity.Property(e => e.Unit6Nc3).HasColumnName("UNIT_6_NC3");

                entity.Property(e => e.Unit7Nc1).HasColumnName("UNIT_7_NC1");

                entity.Property(e => e.Unit8Nc1).HasColumnName("UNIT_8_NC1");

                entity.Property(e => e.Unit8Nc2).HasColumnName("UNIT_8_NC2");

                entity.Property(e => e.Unit9Nc1).HasColumnName("UNIT_9_NC1");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccDeflectorL7>(entity =>
            {
                entity.HasKey(e => e.NrGrawerka)
                    .HasName("HR12CC_DEFLECTOR_L7_PK");

                entity.ToTable("HR12CC_DEFLECTOR_L7");

                entity.HasIndex(e => e.FrameTime, "HR12CC_DEFLECTOR_L7_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "HR12CC_DEFLECTOR_L7_NR_GRW_IDX");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.AngleNakretka1)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("ANGLE_NAKRETKA1");

                entity.Property(e => e.AngleNakretka2)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("ANGLE_NAKRETKA2");

                entity.Property(e => e.AngleNakretka3)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("ANGLE_NAKRETKA3");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.TorqueNakretka1)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("TORQUE_NAKRETKA1");

                entity.Property(e => e.TorqueNakretka2)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("TORQUE_NAKRETKA2");

                entity.Property(e => e.TorqueNakretka3)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("TORQUE_NAKRETKA3");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccFinalleakTesterL7>(entity =>
            {
                entity.HasKey(e => e.NrGrawerka)
                    .HasName("HR12CC_FINALLEAK_TESTER_L7_PK");

                entity.ToTable("HR12CC_FINALLEAK_TESTER_L7");

                entity.HasIndex(e => e.FrameTime, "HR12CC_FINALLEAK_TESTER_L7_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "HR12CC_FINALLEAK_TESTER_L7_NR_GRW_IDX");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.WartoscPrzeplywuRurki1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WARTOSC_PRZEPLYWU_RURKI_1");

                entity.Property(e => e.WartoscPrzeplywuRurki2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WARTOSC_PRZEPLYWU_RURKI_2");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<Hr12ccHomologationL7>(entity =>
            {
                entity.HasKey(e => e.NrGrawerka)
                    .HasName("HR12CC_HOMOLOGATION_L7_PK");

                entity.ToTable("HR12CC_HOMOLOGATION_L7");

                entity.HasIndex(e => e.FrameTime, "HR12CC_HOMOLOGATION_L7_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "HR12CC_HOMOLOGATION_L7_NR_GRW_IDX");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Wady)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WADY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccOutletPressL7>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("HR12CC_OUTLET_PRESS_L7_PK");

                entity.ToTable("HR12CC_OUTLET_PRESS_L7");

                entity.HasIndex(e => e.FrameTime, "HR12CC_OUTLET_PRESS_L7_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "HR12CC_OUTLET_PRESS_L7_NR_GRW_IDX");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccPreleakTesterL7>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("HR12CC_PRELEAK_TESTER_L7_PK");

                entity.ToTable("HR12CC_PRELEAK_TESTER_L7");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.GrawerkaSeq).HasColumnName("GRAWERKA_SEQ");

                entity.Property(e => e.GrawerkaTime).HasColumnName("GRAWERKA_TIME");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<Hr12ccSizerGbdInletL7>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("HR12CC_SIZER_GBD_INLET_L7_PK");

                entity.ToTable("HR12CC_SIZER_GBD_INLET_L7");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.Diameter).HasColumnName("DIAMETER");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrClamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_CLAMSHELL");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccSizerGbdOutletL7>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("HR12CC_SIZER_GBD_OUTLET_L7_PK");

                entity.ToTable("HR12CC_SIZER_GBD_OUTLET_L7");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.Diameter).HasColumnName("DIAMETER");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrClamshell)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_CLAMSHELL");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccTorqueScrewdriverL7>(entity =>
            {
                entity.HasKey(e => e.NrGrawerka)
                    .HasName("HR12CC_TORQUE_SCREWDRIVER_L7_PK");

                entity.ToTable("HR12CC_TORQUE_SCREWDRIVER_L7");

                entity.HasIndex(e => e.FrameTime, "HR12CC_TORQUE_SCREWDRIVER_L7_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "HR12CC_TORQUE_SCREWDRIVER_L7_GRW_IDX");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.AngleNakretka1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ANGLE_NAKRETKA1");

                entity.Property(e => e.AngleNakretka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ANGLE_NAKRETKA2");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7')");

                entity.Property(e => e.TorqueNakretka1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_NAKRETKA1");

                entity.Property(e => e.TorqueNakretka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_NAKRETKA2");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccVacuumCleanerL7>(entity =>
            {
                entity.HasKey(e => e.NrGrawerka)
                    .HasName("HR12CC_VACUUM_CLEANER_L7_PK");

                entity.ToTable("HR12CC_VACUUM_CLEANER_L7");

                entity.HasIndex(e => e.FrameTime, "HR12CC_VACUUM_CELANER_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "HR12CC_VACUUM_CLEANER_L7_NR_GRW_IDX");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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

            modelBuilder.Entity<Hr12ccWeldingCellInletBasicClamshellOp3L7>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("HR12CC_WELDING_CELL_INLET_BASIC_CLAMSHELL_OP3_L7_PK");

                entity.ToTable("HR12CC_WELDING_CELL_INLET_BASIC_CLAMSHELL_OP3_L7");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7_STN1')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccWeldingCellInletOutletBasicMidclamshellL7>(entity =>
            {
                entity.HasKey(e => e.NrShellaOutlet)
                    .HasName("HR12CC_INLET_OUTLET_BASIC_MIDCLAMSHELL_L7_PK");

                entity.ToTable("HR12CC_WELDING_CELL_INLET_OUTLET_BASIC_MIDCLAMSHELL_L7");

                entity.Property(e => e.NrShellaOutlet)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_OUTLET");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrMidclamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIDCLAMSHELL");

                entity.Property(e => e.NrShellaInlet)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_INLET");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccWeldingCellIntletBasicMidclamshellOp8L7>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("HR12CC_WELDING_CELL_INTLET_BASIC_MIDCLAMSHELL_OP8_L7_PK");

                entity.ToTable("HR12CC_WELDING_CELL_INTLET_BASIC_MIDCLAMSHELL_OP8_L7");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7_STN1')");

                entity.Property(e => e.NrMidclamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIDCLAMSHELL");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccWeldingCellMidclamshellOp7L7>(entity =>
            {
                entity.HasKey(e => e.NrMidclamshell)
                    .HasName("HR12CC_WELDING_CELL_MIDCLAMSHELL_OP7_L7_PK");

                entity.ToTable("HR12CC_WELDING_CELL_MIDCLAMSHELL_OP7_L7");

                entity.Property(e => e.NrMidclamshell)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIDCLAMSHELL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7_STN1')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ccWeldingCellOutletBasicClamshellOp6L7>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("HR12CC_WELDING_CELL_OUTLET_BASIC_CLAMSHELL_OP6_L7_PK");

                entity.ToTable("HR12CC_WELDING_CELL_OUTLET_BASIC_CLAMSHELL_OP6_L7");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L7_STN1')");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr12ufControlLoopL6>(entity =>
            {
                entity.HasKey(e => e.NrKatalizatora)
                    .HasName("HR12UF_CONTROL_LOOP_L6_PK");

                entity.ToTable("HR12UF_CONTROL_LOOP_L6");

                entity.HasIndex(e => e.DtOperacji, "HR12UF_CONTROL_LOOP_L6_DT_OPERACJI");

                entity.HasIndex(e => e.FrameTime, "HR12UF_CONTROL_LOOP_L6_FRAME_TIME");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "HR12UF_CONTROL_LOOP_L6_FRAME_TIME_WYNIK");

                entity.HasIndex(e => new { e.FrameTime, e.WynikOperacji, e.NrPzzw }, "HR12UF_CONTROL_LOOP_L6_FRAME_TIME_WYNIK_PZZW");

                entity.Property(e => e.NrKatalizatora)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

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

            modelBuilder.Entity<Hr12ufFinalGaugeL6>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("HR12UF_FINAL_GAUGE_L6_PK");

                entity.ToTable("HR12UF_FINAL_GAUGE_L6");

                entity.HasIndex(e => e.DtOperacji, "HR12UF_FINAL_GAUGE_L6_DT_OPERACJi");

                entity.HasIndex(e => e.FrameTime, "HR12UF_FINAL_GAUGE_L6_FRAME_TIME");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "HR12UF_FINAL_GAUGE_L6_FRAME_TIME_WYNIK");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("Nr shella");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.InletBracketStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("INLET_BRACKET_STATUS");

                entity.Property(e => e.InletBrackteValue).HasColumnName("INLET_BRACKTE_VALUE");

                entity.Property(e => e.InletStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("INLET_STATUS");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('L1')");

                entity.Property(e => e.OutletBracketStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OUTLET_BRACKET_STATUS");

                entity.Property(e => e.OutletBrackteValue).HasColumnName("OUTLET_BRACKTE_VALUE");

                entity.Property(e => e.OutletStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OUTLET_STATUS");

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

            modelBuilder.Entity<Hr12ufLeaktesterL6>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("HR12UF_LEAKTESTER_L6_PK");

                entity.ToTable("HR12UF_LEAKTESTER_L6");

                entity.HasIndex(e => e.DtOperacji, "HR12UF_FINAL_GAUGE_L6");

                entity.HasIndex(e => e.FrameTime, "HR12UF_FINAL_GAUGE_L6_FRAME_TIME");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "HR12UF_FINAL_GAUGE_L6_FRAME_TIME_WYNIK");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("Nr shella");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI")
                    .HasComment("Wynik operacji NOK/OK");
            });

            modelBuilder.Entity<Hr12ufMarkingL6>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("HR12UF_MARKING_L6_PK");

                entity.ToTable("HR12UF_MARKING_L6");

                entity.HasIndex(e => e.DtOperacji, "HR12UF_MARKING_L6_DT_OPERACJI");

                entity.HasIndex(e => e.FrameTime, "HR12UF_MARKING_L6_FRAME_TIME");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("Nr shella");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

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

            modelBuilder.Entity<Hr12ufReworkL6>(entity =>
            {
                entity.ToTable("HR12UF_REWORK_L6");

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
                    .HasColumnName("NR_KODU");

                entity.Property(e => e.WadaJakosciowa)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WADA_JAKOSCIOWA");
            });

            modelBuilder.Entity<Hr12ufSizerInletL6>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("HR12UF_SIZER_L6_PK");

                entity.ToTable("HR12UF_SIZER_INLET_L6");

                entity.HasIndex(e => e.DtOperacji, "HR12UF_SIZER_L6_DT_OPERACJI");

                entity.HasIndex(e => e.FrameTime, "HR12UF_SIZER_L6_FRAME_TIME");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "HR12UF_SIZER_L6_FRAME_TIME_WYNIK");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("Nr shella");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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

            modelBuilder.Entity<Hr12ufSizerOutletL6>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("HR12UF_SIZER_OUTLET_L6_PK");

                entity.ToTable("HR12UF_SIZER_OUTLET_L6");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("Nr shella");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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

            modelBuilder.Entity<Hr12ufVacuumL6>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("HR12UF_VACUUM_L6_PK");

                entity.ToTable("HR12UF_VACUUM_L6");

                entity.HasIndex(e => e.DtOperacji, "HR12UF_VACUUM_L6_DT_OPERACJI");

                entity.HasIndex(e => e.FrameTime, "HR12UF_VACUUM_L6_FRAME_TIME");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "HR12UF_VACUUM_L6_FRAME_TIME_WYNIK");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("Nr shella");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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

            modelBuilder.Entity<Hr12ufWeldingCellL6>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("HR12UF_WELDING_CELL_L6_PK");

                entity.ToTable("HR12UF_WELDING_CELL_L6");

                entity.HasIndex(e => e.DtOperacji, "HR12UF_WELDING_CELL_L6");

                entity.HasIndex(e => e.FrameTime, "HR12UF_WELDING_CELL_L6_FRAME_TIME");

                entity.HasIndex(e => new { e.WynikOperacji, e.FrameTime }, "HR12UF_WELDING_CELL_L6_FRAME_TIME_WYNIK");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("Nr shella");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII")
                    .HasDefaultValueSql("('C1_STN1')");

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

            modelBuilder.Entity<Hr18ControlLoopL5>(entity =>
            {
                entity.HasKey(e => e.NrKatalizatora)
                    .HasName("HR18_CONTROL_LOOP_L5_PK");

                entity.ToTable("HR18_CONTROL_LOOP_L5");

                entity.HasIndex(e => e.DtOperacji, "HR18_CONTROL_LOOP_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "HR18_CONTROL_LOOP_L5_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "HR18_CONTROL_LOOP_L5_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrKatalizatora)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

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

            modelBuilder.Entity<Hr18FinalGaugeL5>(entity =>
            {
                entity.HasKey(e => new { e.NrShella, e.NrGrawerka })
                    .HasName("HR18_FINAL_GAUGE_L5_PK");

                entity.ToTable("HR18_FINAL_GAUGE_L5");

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

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

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

            modelBuilder.Entity<Hr18LeaktesterL5>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("HR18_PRELEAKTESTER_L5_PK");

                entity.ToTable("HR18_LEAKTESTER_L5");

                entity.HasIndex(e => e.DtOperacji, "HR18_LEAKTESTER_L5_DT_OPERACJI");

                entity.HasIndex(e => e.FrameTime, "HR18_LEAKTESTER_L5_FRAME_TIME");

                entity.HasIndex(e => new { e.FrameTime, e.WynikOperacji }, "HR18_LEAKTESTER_L5_FRAME_TIME_WYNIK");

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

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

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

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr18VacuumL5>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("HR18_VACUUM_CLEANING_L5_PK");

                entity.ToTable("HR18_VACUUM_L5");

                entity.HasIndex(e => e.DtOperacji, "HR18_VACUUM_L5_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "HR18_VACUUM_L5_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "HR18_VACUUM_L5_FRAME_TIME_WYNIK_OPERACJI");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

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

                entity.Property(e => e.Vacuum1).HasColumnName("VACUUM_1");

                entity.Property(e => e.Vacuum2).HasColumnName("VACUUM_2");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<Hr18WeldingCellL5>(entity =>
            {
                entity.HasKey(e => e.NrBasic)
                    .HasName("HR18_WELDING_CELL_L5_PK");

                entity.ToTable("HR18_WELDING_CELL_L5");

                entity.HasIndex(e => e.FrameTime2, "HR18_WELDING_CELL_L5_FRAME_TIME_2_IDX");

                entity.HasIndex(e => e.FrameTime3, "HR18_WELDING_CELL_L5_FRAME_TIME_3_IDX");

                entity.HasIndex(e => e.FrameTime4, "HR18_WELDING_CELL_L5_FRAME_TIME_4_IDX");

                entity.HasIndex(e => e.FrameTime, "HR18_WELDING_CELL_L5_FRAME_TIME_IDX");

                entity.Property(e => e.NrBasic)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC")
                    .HasComment("Nr basic");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameSeq4).HasColumnName("FRAME_SEQ_4");

                entity.Property(e => e.FrameSeq5).HasColumnName("FRAME_SEQ_5");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.FrameTime4).HasColumnName("FRAME_TIME_4");

                entity.Property(e => e.FrameTime5).HasColumnName("FRAME_TIME_5");

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

            modelBuilder.Entity<M260LaserMarkingL4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_LASER_MARKING_L4_PK");

                entity.ToTable("M260_LASER_MARKING_L4");

                entity.HasIndex(e => e.DtOperacji, "M260_LASER_MARKING_L4_DT_OPERACJI_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_LASER_MARKING_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_LASER_MARKING_L4_FRAME_TIME_WYNIK_OPERACJI");

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

                entity.Property(e => e.Duplikacja).HasColumnName("DUPLIKACJA");

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

            modelBuilder.Entity<M260ReprintL4>(entity =>
            {
                entity.ToTable("M260_REPRINT_L4");

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

                entity.Property(e => e.Kod)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("KOD");
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

            modelBuilder.Entity<M260ReworkOslonyL4>(entity =>
            {
                entity.ToTable("M260_REWORK_OSLONY_L4");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrShella)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");
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

                entity.Property(e => e.NrEtykiety)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_ETYKIETY");

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

            modelBuilder.Entity<M260WeldingCell1L4>(entity =>
            {
                entity.HasKey(e => e.NrShella)
                    .HasName("M260_WELDING_CELL_1_L4_PK");

                entity.ToTable("M260_WELDING_CELL_1_L4");

                entity.HasIndex(e => e.FrameTime, "M260_WELDING_CELL_1_L4_FRAME_TIME_IDX");

                entity.HasIndex(e => e.FrameTime, "M260_WELDING_CELL_1_L4_FRAME_TIME_WYNIK_OPERACJI");

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

                entity.Property(e => e.Strona)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("STRONA");

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

                entity.HasIndex(e => e.CsmBrickCode, "IDX_PANEL_FONTIJNE_L1_BRICK_CODE_1");

                entity.HasIndex(e => e.Csm2BrickCode, "IDX_PANEL_FONTIJNE_L1_BRICK_CODE_2");

                entity.HasIndex(e => e.FrameTime, "IDX_PANEL_FONTIJNE_L1_FRAME_TIME");

                entity.HasIndex(e => e.FrameTime2, "IDX_PANEL_FONTIJNE_L1_FRAME_TIME_2");

                entity.HasIndex(e => e.FrameTime3, "IDX_PANEL_FONTIJNE_L1_FRAME_TIME_3");

                entity.HasIndex(e => e.FrameTime4, "IDX_PANEL_FONTIJNE_L1_FRAME_TIME_4");

                entity.HasIndex(e => e.ManufacturingLotTraceCodeOutlet, "IDX_PANEL_FONTIJNE_L1_SHELL_2_NO");

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

            modelBuilder.Entity<ReworkHr12ccL7>(entity =>
            {
                entity.ToTable("REWORK_HR12CC_L7");

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

            modelBuilder.Entity<ReworkM260aL4>(entity =>
            {
                entity.ToTable("REWORK_M260A_L4");

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
                    .HasColumnName("NR_KODU");

                entity.Property(e => e.WadaJakosciowa)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WADA_JAKOSCIOWA");
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

            modelBuilder.Entity<ShellLineDimecoL0>(entity =>
            {
                entity.ToTable("SHELL_LINE_DIMECO_L0");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BATCH_NUMBER");

                entity.Property(e => e.CanUsed).HasColumnName("CAN_USED");

                entity.Property(e => e.CodeBlankPalet)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_BLANK_PALET");

                entity.Property(e => e.CodeCoil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_COIL");

                entity.Property(e => e.CodeLot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_LOT");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PART_NUMBER");

                entity.Property(e => e.PartsProduced).HasColumnName("PARTS_PRODUCED");

                entity.Property(e => e.PartsRemaining).HasColumnName("PARTS_REMAINING");

                entity.Property(e => e.WeightBlank).HasColumnName("WEIGHT_BLANK");

                entity.Property(e => e.WeightCoil).HasColumnName("WEIGHT_COIL");
            });

            modelBuilder.Entity<ShellLineWeilL0>(entity =>
            {
                entity.ToTable("SHELL_LINE_WEIL_L0");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CanUsed).HasColumnName("CAN_USED");

                entity.Property(e => e.CodeBlank)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_BLANK");

                entity.Property(e => e.CodeCan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE_CAN");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PART_NUMBER");

                entity.Property(e => e.PartsProduced).HasColumnName("PARTS_PRODUCED");

                entity.Property(e => e.PartsRemaining).HasColumnName("PARTS_REMAINING");
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

            modelBuilder.Entity<VCela1And2Hr16L3All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CELA_1_AND_2_HR16_L3_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
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

            modelBuilder.Entity<VCela3Hr16L3All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CELA_3_HR16_L3_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameSeq4).HasColumnName("FRAME_SEQ_4");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.FrameTime4).HasColumnName("FRAME_TIME_4");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VCela5AbbBr10L2All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CELA_5_ABB_BR10_L2_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VCela8AbbL1All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CELA_8_ABB_L1_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VCheckFixtureL1All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CHECK_FIXTURE_L1_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

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
                    .HasColumnName("UNIT_OK_NOK_0");

                entity.Property(e => e.UnitOkNok1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_1");

                entity.Property(e => e.UnitOkNok10)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_10");

                entity.Property(e => e.UnitOkNok11)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_11");

                entity.Property(e => e.UnitOkNok12)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_12");

                entity.Property(e => e.UnitOkNok13)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_13");

                entity.Property(e => e.UnitOkNok14)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_14");

                entity.Property(e => e.UnitOkNok15)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_15");

                entity.Property(e => e.UnitOkNok16)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_16");

                entity.Property(e => e.UnitOkNok17)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_17");

                entity.Property(e => e.UnitOkNok18)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_18");

                entity.Property(e => e.UnitOkNok19)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_19");

                entity.Property(e => e.UnitOkNok2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_2");

                entity.Property(e => e.UnitOkNok3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_3");

                entity.Property(e => e.UnitOkNok4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_4");

                entity.Property(e => e.UnitOkNok5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_5");

                entity.Property(e => e.UnitOkNok6)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_6");

                entity.Property(e => e.UnitOkNok7)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_7");

                entity.Property(e => e.UnitOkNok8)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_8");

                entity.Property(e => e.UnitOkNok9)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_9");

                entity.Property(e => e.VariantDetGpf0)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("VARIANT_DET_GPF_0");

                entity.Property(e => e.VariantDetGpf1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("VARIANT_DET_GPF_1");

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

            modelBuilder.Entity<VEnkapsulacjaBr10L2All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ENKAPSULACJA_BR10_L2_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VFinalGaugeBr10L2All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FINAL_GAUGE_BR10_L2_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

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
                    .HasColumnName("UNIT_OK_NOK_0");

                entity.Property(e => e.UnitOkNok1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_1");

                entity.Property(e => e.UnitOkNok10)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_10");

                entity.Property(e => e.UnitOkNok11)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_11");

                entity.Property(e => e.UnitOkNok12)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_12");

                entity.Property(e => e.UnitOkNok13)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_13");

                entity.Property(e => e.UnitOkNok14)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_14");

                entity.Property(e => e.UnitOkNok15)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_15");

                entity.Property(e => e.UnitOkNok16)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_16");

                entity.Property(e => e.UnitOkNok17)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_17");

                entity.Property(e => e.UnitOkNok18)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_18");

                entity.Property(e => e.UnitOkNok19)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_19");

                entity.Property(e => e.UnitOkNok2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_2");

                entity.Property(e => e.UnitOkNok3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_3");

                entity.Property(e => e.UnitOkNok4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_4");

                entity.Property(e => e.UnitOkNok5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_5");

                entity.Property(e => e.UnitOkNok6)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_6");

                entity.Property(e => e.UnitOkNok7)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_7");

                entity.Property(e => e.UnitOkNok8)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_8");

                entity.Property(e => e.UnitOkNok9)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_9");

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

            modelBuilder.Entity<VFinalGaugeHr16L3All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FINAL_GAUGE_HR16_L3_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VFinalLeaktesterHr16L3All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FINAL_LEAKTESTER_HR16_L3_ALL");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
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

            modelBuilder.Entity<VFinalleakTesterL1All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FINALLEAK_TESTER_L1_ALL");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.WartoscPrzeplywuRurki1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WARTOSC_PRZEPLYWU_RURKI_1");

                entity.Property(e => e.WartoscPrzeplywuRurki2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WARTOSC_PRZEPLYWU_RURKI_2");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

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

            modelBuilder.Entity<VGbdIoCalibrationBr10L2All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_GBD_IO_CALIBRATION_BR10_L2_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHomologationL1All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HOMOLOGATION_L1_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Wady)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WADY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
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

            modelBuilder.Entity<VHr12ccCell3L7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_CELL_3_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrClamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_CLAMSHELL");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccCell4L7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_CELL_4_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrClamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_CLAMSHELL");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShellaInlet)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_INLET");

                entity.Property(e => e.NrShellaOutlet)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_OUTLET");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccCheckFixtureL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_CHECK_FIXTURE_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

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

                entity.Property(e => e.Unit18)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_8");

                entity.Property(e => e.Unit19)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("UNIT_1_9");

                entity.Property(e => e.UnitOkNok10)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_10");

                entity.Property(e => e.UnitOkNok11)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_11");

                entity.Property(e => e.UnitOkNok12)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_12");

                entity.Property(e => e.UnitOkNok2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_2");

                entity.Property(e => e.UnitOkNok3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_3");

                entity.Property(e => e.UnitOkNok4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_4");

                entity.Property(e => e.UnitOkNok5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_5");

                entity.Property(e => e.UnitOkNok6)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_6");

                entity.Property(e => e.UnitOkNok7)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_7");

                entity.Property(e => e.UnitOkNok8)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_8");

                entity.Property(e => e.UnitOkNok9)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_OK_NOK_9");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccControlLoopL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_CONTROL_LOOP_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrKatalizatora)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NR_OPERATORA");

                entity.Property(e => e.NrPzzw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NR_PZZW");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VHr12ccDeflectorGaugeL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_DEFLECTOR_GAUGE_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Unit10Nc1).HasColumnName("UNIT_10_NC1");

                entity.Property(e => e.Unit10Nc2).HasColumnName("UNIT_10_NC2");

                entity.Property(e => e.Unit10Nc3).HasColumnName("UNIT_10_NC3");

                entity.Property(e => e.Unit10Nc4).HasColumnName("UNIT_10_NC4");

                entity.Property(e => e.Unit11Nc1).HasColumnName("UNIT_11_NC1");

                entity.Property(e => e.Unit12Nc1).HasColumnName("UNIT_12_NC1");

                entity.Property(e => e.Unit4).HasColumnName("UNIT_4");

                entity.Property(e => e.Unit6Nc1).HasColumnName("UNIT_6_NC1");

                entity.Property(e => e.Unit6Nc2).HasColumnName("UNIT_6_NC2");

                entity.Property(e => e.Unit6Nc3).HasColumnName("UNIT_6_NC3");

                entity.Property(e => e.Unit7Nc1).HasColumnName("UNIT_7_NC1");

                entity.Property(e => e.Unit8Nc1).HasColumnName("UNIT_8_NC1");

                entity.Property(e => e.Unit8Nc2).HasColumnName("UNIT_8_NC2");

                entity.Property(e => e.Unit9Nc1).HasColumnName("UNIT_9_NC1");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccDeflectorL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_DEFLECTOR_L7_ALL");

                entity.Property(e => e.AngleNakretka1)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("ANGLE_NAKRETKA1");

                entity.Property(e => e.AngleNakretka2)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("ANGLE_NAKRETKA2");

                entity.Property(e => e.AngleNakretka3)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("ANGLE_NAKRETKA3");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TorqueNakretka1)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("TORQUE_NAKRETKA1");

                entity.Property(e => e.TorqueNakretka2)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("TORQUE_NAKRETKA2");

                entity.Property(e => e.TorqueNakretka3)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("TORQUE_NAKRETKA3");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccFinalleakTesterL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_FINALLEAK_TESTER_L7_ALL");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.WartoscPrzeplywuRurki1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WARTOSC_PRZEPLYWU_RURKI_1");

                entity.Property(e => e.WartoscPrzeplywuRurki2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WARTOSC_PRZEPLYWU_RURKI_2");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<VHr12ccHomologationL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_HOMOLOGATION_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Wady)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WADY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccOutletPressL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_OUTLET_PRESS_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccPreleakTesterL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_PRELEAK_TESTER_L7_ALL");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.GrawerkaSeq).HasColumnName("GRAWERKA_SEQ");

                entity.Property(e => e.GrawerkaTime).HasColumnName("GRAWERKA_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
            });

            modelBuilder.Entity<VHr12ccSizerGbdInletL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_SIZER_GBD_INLET_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrClamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_CLAMSHELL");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccSizerGbdOutletL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_SIZER_GBD_OUTLET_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrClamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_CLAMSHELL");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccTorqueScrewdriverL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_TORQUE_SCREWDRIVER_L7_ALL");

                entity.Property(e => e.AngleNakretka1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ANGLE_NAKRETKA1");

                entity.Property(e => e.AngleNakretka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ANGLE_NAKRETKA2");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TorqueNakretka1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_NAKRETKA1");

                entity.Property(e => e.TorqueNakretka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_NAKRETKA2");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccVacuumCleanerL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_VACUUM_CLEANER_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccWeldingCellInletBasicClamshellOp3L7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_WELDING_CELL_INLET_BASIC_CLAMSHELL_OP3_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccWeldingCellInletOutletBasicMidclamshellL7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_WELDING_CELL_INLET_OUTLET_BASIC_MIDCLAMSHELL_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrMidclamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIDCLAMSHELL");

                entity.Property(e => e.NrShellaInlet)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_INLET");

                entity.Property(e => e.NrShellaOutlet)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA_OUTLET");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccWeldingCellIntletBasicMidclamshellOp8L7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_WELDING_CELL_INTLET_BASIC_MIDCLAMSHELL_OP8_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrMidclamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIDCLAMSHELL");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccWeldingCellMidclamshellOp7L7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_WELDING_CELL_MIDCLAMSHELL_OP7_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrMidclamshell)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_MIDCLAMSHELL");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ccWeldingCellOutletBasicClamshellOp6L7All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12CC_WELDING_CELL_OUTLET_BASIC_CLAMSHELL_OP6_L7_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ufControlLoopL6All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12UF_CONTROL_LOOP_L6_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrKatalizatora)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NR_OPERATORA");

                entity.Property(e => e.NrPzzw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NR_PZZW");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VHr12ufFinalGaugeL6All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12UF_FINAL_GAUGE_L6_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.InletBracketStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("INLET_BRACKET_STATUS");

                entity.Property(e => e.InletBrackteValue).HasColumnName("INLET_BRACKTE_VALUE");

                entity.Property(e => e.InletStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("INLET_STATUS");

                entity.Property(e => e.NrBasic)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.OutletBracketStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OUTLET_BRACKET_STATUS");

                entity.Property(e => e.OutletBrackteValue).HasColumnName("OUTLET_BRACKTE_VALUE");

                entity.Property(e => e.OutletStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("OUTLET_STATUS");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ufLeaktesterL6All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12UF_LEAKTESTER_L6_ALL");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrBasic)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ufMarkingL6All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12UF_MARKING_L6_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrBasic)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC");

                entity.Property(e => e.NrGrawerka)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ufSizerInletL6All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12UF_SIZER_INLET_L6_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrBasic)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ufSizerOutletL6All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12UF_SIZER_OUTLET_L6_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrBasic)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ufVacuumL6All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12UF_VACUUM_L6_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrBasic)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr12ufWeldingCellL6All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR12UF_WELDING_CELL_L6_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrBasic)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr18ControlLoopL5All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR18_CONTROL_LOOP_L5_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrKatalizatora)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_KATALIZATORA");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.NrOperatora)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NR_OPERATORA");

                entity.Property(e => e.NrPzzw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NR_PZZW");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VHr18FinalGaugeL5All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR18_FINAL_GAUGE_L5_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

            modelBuilder.Entity<VHr18LeaktesterL5All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR18_LEAKTESTER_L5_ALL");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.GrawerkaTime).HasColumnName("GRAWERKA_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrGrawerka)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_GRAWERKA");

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

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr18VacuumL5All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR18_VACUUM_L5_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.Vacuum1).HasColumnName("VACUUM_1");

                entity.Property(e => e.Vacuum2).HasColumnName("VACUUM_2");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VHr18WeldingCellL5All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_HR18_WELDING_CELL_L5_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameSeq4).HasColumnName("FRAME_SEQ_4");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.FrameTime4).HasColumnName("FRAME_TIME_4");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrBasic)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_BASIC");

                entity.Property(e => e.NrLinii)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VInletPressL1All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_INLET_PRESS_L1_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VLeakTesterBr10L2All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_LEAK_TESTER_BR10_L2_ALL");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.GrawerkaSeq).HasColumnName("GRAWERKA_SEQ");

                entity.Property(e => e.GrawerkaTime).HasColumnName("GRAWERKA_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
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

            modelBuilder.Entity<VM260BracketChecksL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_BRACKET_CHECKS_L4_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrEtykiety)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_ETYKIETY");

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

            modelBuilder.Entity<VM260ControlLoopL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_CONTROL_LOOP_L4_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VM260EncapsulationBodyL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_ENCAPSULATION_BODY_L4_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

            modelBuilder.Entity<VM260EncapsulationPipeL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_ENCAPSULATION_PIPE_L4_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

            modelBuilder.Entity<VM260GbdIoCalibrationL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_GBD_IO_CALIBRATION_L4_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

            modelBuilder.Entity<VM260GeometryGaugeL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_GEOMETRY_GAUGE_L4_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

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
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VM260LeakTesterAndMarkingL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_LEAK_TESTER_AND_MARKING_L4_ALL");

                entity.Property(e => e.Cisnienie).HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Wyciek).HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VM260PreleakTesterL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_PRELEAK_TESTER_L4_ALL");

                entity.Property(e => e.Cisnienie).HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.Duplikacja).HasColumnName("DUPLIKACJA");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Wyciek).HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VM260PressStationL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_PRESS_STATION_L4_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

            modelBuilder.Entity<VM260ResistanceWeldingL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_RESISTANCE_WELDING_L4_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

            modelBuilder.Entity<VM260VacuumL4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_VACUUM_L4_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrEtykiety)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_ETYKIETY");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Vacuum1).HasColumnName("VACUUM_1");

                entity.Property(e => e.Vacuum2).HasColumnName("VACUUM_2");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VM260WeldingCell1L4All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_M260_WELDING_CELL_1_L4_ALL");

                entity.Property(e => e.DtOperacji)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_OPERACJI");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.Strona)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("STRONA");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
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

            modelBuilder.Entity<VOutletPressL1All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_OUTLET_PRESS_L1_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

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

            modelBuilder.Entity<VPreleakTesterL1All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PRELEAK_TESTER_L1_ALL");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

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

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

                entity.Property(e => e.WynikTestu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_TESTU");
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

            modelBuilder.Entity<VPreleaktesterHr16L3All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PRELEAKTESTER_HR16_L3_ALL");

                entity.Property(e => e.Cisnienie)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE");

                entity.Property(e => e.CisnienieJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("CISNIENIE_JEDN");

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

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.Wyciek)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK");

                entity.Property(e => e.WyciekJedn)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("WYCIEK_JEDN");

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

            modelBuilder.Entity<VStf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_STF");

                entity.Property(e => e.CmsMarkingOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CMS_MarkingOK_Nok");

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

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OempartNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("OEMPartNumber");

                entity.Property(e => e.ShellWallThickness).HasColumnType("decimal(12, 6)");
            });

            modelBuilder.Entity<VStf3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_STF3");

                entity.Property(e => e.CvmDateofMeasurement)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CVM_DateofMeasurement");

                entity.Property(e => e.CvmMeasurementOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CVM_MeasurementOk_Nok");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OempartNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("OEMPartNumber");
            });

            modelBuilder.Entity<VStf4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_STF4");

                entity.Property(e => e.CvmDateofMeasurement)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CVM_DateofMeasurement");

                entity.Property(e => e.CvmMeasurementOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CVM_MeasurementOk_Nok");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OempartNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("OEMPartNumber");
            });

            modelBuilder.Entity<VStf5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_STF5");

                entity.Property(e => e.CvmDateofMeasurement)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CVM_DateofMeasurement");

                entity.Property(e => e.CvmMeasurementOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CVM_MeasurementOk_Nok");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OempartNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("OEMPartNumber");
            });

            modelBuilder.Entity<VStf6>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_STF6");

                entity.Property(e => e.CvmDateofMeasurement)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CVM_DateofMeasurement");

                entity.Property(e => e.CvmMeasurementOkNok)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CVM_MeasurementOk_Nok");

                entity.Property(e => e.FrameTime4).HasColumnName("FRAME_TIME_4");

                entity.Property(e => e.NrLinii)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_LINII");

                entity.Property(e => e.OempartNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("OEMPartNumber");
            });

            modelBuilder.Entity<VTorqueScrewdriverL1All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TORQUE_SCREWDRIVER_L1_ALL");

                entity.Property(e => e.AngleNakretka1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ANGLE_NAKRETKA1");

                entity.Property(e => e.AngleNakretka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("ANGLE_NAKRETKA2");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameSeq2).HasColumnName("FRAME_SEQ_2");

                entity.Property(e => e.FrameSeq3).HasColumnName("FRAME_SEQ_3");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.FrameTime2).HasColumnName("FRAME_TIME_2");

                entity.Property(e => e.FrameTime3).HasColumnName("FRAME_TIME_3");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TorqueNakretka1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_NAKRETKA1");

                entity.Property(e => e.TorqueNakretka2)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("TORQUE_NAKRETKA2");

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
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

            modelBuilder.Entity<VWiremeshBr10L2All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WIREMESH_BR10_L2_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

                entity.Property(e => e.NrShella)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NR_SHELLA");

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

                entity.Property(e => e.WynikOperacji)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("WYNIK_OPERACJI");
            });

            modelBuilder.Entity<VWkretakBr10L2All>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_WKRETAK_BR10_L2_ALL");

                entity.Property(e => e.FrameSeq).HasColumnName("FRAME_SEQ");

                entity.Property(e => e.FrameTime).HasColumnName("FRAME_TIME");

                entity.Property(e => e.IdHist).HasColumnName("_ID_HIST");

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

                entity.Property(e => e.OpTime)
                    .HasColumnType("datetime")
                    .HasColumnName("_OP_TIME");

                entity.Property(e => e.Oper)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("_OPER")
                    .IsFixedLength(true);

                entity.Property(e => e.TrybPracy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TRYB_PRACY");

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

            modelBuilder.Entity<ZgrzewaniePatchL1>(entity =>
            {
                entity.HasKey(e => new { e.NrShella, e.NrGrawerka })
                    .HasName("ZGRZEWANIE_PATCH_L1_PK");

                entity.ToTable("ZGRZEWANIE_PATCH_L1");

                entity.HasIndex(e => e.FrameTime, "ZGRZEWANIE_PATCH_L1_FRAME_TIME_IDX");

                entity.HasIndex(e => e.NrGrawerka, "ZGRZEWANIE_PATCH_L1_NR_GRW_IDX");

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
