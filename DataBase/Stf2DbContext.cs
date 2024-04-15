using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebMonitoring.Table.STF2;

#nullable disable

namespace WebMonitoring.DataBase
{
    public partial class Stf2DbContext : DbContext
    {
        public Stf2DbContext()
        {
        }

        public Stf2DbContext(DbContextOptions<Stf2DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBrick> TblBricks { get; set; }
        public virtual DbSet<TblMat> TblMats { get; set; }
        public virtual DbSet<TblShell> TblShells { get; set; }
        public virtual DbSet<TblSubAssembly> TblSubAssemblies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source= 172.16.2.203,1433\\2024690-001;Initial Catalog= GWS_B20;Persist Security Info=True;User ID=pwRoch;Password=pwRoch;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblBrick>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblBricks");

                entity.Property(e => e.BPass).HasColumnName("bPass");

                entity.Property(e => e.DtMeasure)
                    .HasColumnType("datetime")
                    .HasColumnName("dtMeasure");

                entity.Property(e => e.FAvgPerim).HasColumnName("fAvgPerim");

                entity.Property(e => e.FLength).HasColumnName("fLength");

                entity.Property(e => e.FZ1maxDim).HasColumnName("fZ1MaxDim");

                entity.Property(e => e.FZ1minDim).HasColumnName("fZ1MinDim");

                entity.Property(e => e.FZ1perim).HasColumnName("fZ1Perim");

                entity.Property(e => e.FZ2maxDim).HasColumnName("fZ2MaxDim");

                entity.Property(e => e.FZ2minDim).HasColumnName("fZ2MinDim");

                entity.Property(e => e.FZ2perim).HasColumnName("fZ2Perim");

                entity.Property(e => e.FZ3maxDim).HasColumnName("fZ3MaxDim");

                entity.Property(e => e.FZ3minDim).HasColumnName("fZ3MinDim");

                entity.Property(e => e.FZ3perim).HasColumnName("fZ3Perim");

                entity.Property(e => e.IBrickNumber).HasColumnName("iBrickNumber");

                entity.Property(e => e.VBrickSerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("vBrickSerialNum");

                entity.Property(e => e.VMfgLotCode)
                    .HasMaxLength(50)
                    .HasColumnName("vMfgLotCode");

                entity.Property(e => e.VMfgPartNum)
                    .HasMaxLength(50)
                    .HasColumnName("vMfgPartNum");

                entity.Property(e => e.VPartNum)
                    .HasMaxLength(50)
                    .HasColumnName("vPartNum");
            });

            modelBuilder.Entity<TblMat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblMats");

                entity.Property(e => e.BPass).HasColumnName("bPass");

                entity.Property(e => e.DtMeasure)
                    .HasColumnType("datetime")
                    .HasColumnName("dtMeasure");

                entity.Property(e => e.FMatArea).HasColumnName("fMatArea");

                entity.Property(e => e.FMatThickness).HasColumnName("fMatThickness");

                entity.Property(e => e.FMatWeight).HasColumnName("fMatWeight");

                entity.Property(e => e.FMaxWeight).HasColumnName("fMaxWeight");

                entity.Property(e => e.FMinWeight).HasColumnName("fMinWeight");

                entity.Property(e => e.FNominalWeight).HasColumnName("fNominalWeight");

                entity.Property(e => e.IMatNumber).HasColumnName("iMatNumber");

                entity.Property(e => e.VMatMfgLotNum)
                    .HasMaxLength(50)
                    .HasColumnName("vMatMfgLotNum");

                entity.Property(e => e.VMatSerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("vMatSerialNum");

                entity.Property(e => e.VPartNum)
                    .HasMaxLength(50)
                    .HasColumnName("vPartNum");
            });

            modelBuilder.Entity<TblShell>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblShells");

                entity.Property(e => e.BPass).HasColumnName("bPass");

                entity.Property(e => e.DtMeasure)
                    .HasColumnType("datetime")
                    .HasColumnName("dtMeasure");

                entity.Property(e => e.FAvgGbdregion1).HasColumnName("fAvgGBDRegion1");

                entity.Property(e => e.FAvgGbdregion2).HasColumnName("fAvgGBDRegion2");

                entity.Property(e => e.FAvgPerimRegion1).HasColumnName("fAvgPerimRegion1");

                entity.Property(e => e.FAvgPerimRegion2).HasColumnName("fAvgPerimRegion2");

                entity.Property(e => e.FGbd1minusTolerance).HasColumnName("fGBD1MinusTolerance");

                entity.Property(e => e.FGbd1plusTolerance).HasColumnName("fGBD1PlusTolerance");

                entity.Property(e => e.FGbd2minusTolerance).HasColumnName("fGBD2MinusTolerance");

                entity.Property(e => e.FGbd2plusTolerance).HasColumnName("fGBD2PlusTolerance");

                entity.Property(e => e.FTargetGbd1).HasColumnName("fTargetGBD1");

                entity.Property(e => e.FTargetGbd2).HasColumnName("fTargetGBD2");

                entity.Property(e => e.FWallThickness).HasColumnName("fWallThickness");

                entity.Property(e => e.FZ1gbd).HasColumnName("fZ1GBD");

                entity.Property(e => e.FZ1maxDim).HasColumnName("fZ1MaxDim");

                entity.Property(e => e.FZ1minDim).HasColumnName("fZ1MinDim");

                entity.Property(e => e.FZ1perim).HasColumnName("fZ1Perim");

                entity.Property(e => e.FZ2gbd).HasColumnName("fZ2GBD");

                entity.Property(e => e.FZ2maxDim).HasColumnName("fZ2MaxDim");

                entity.Property(e => e.FZ2minDim).HasColumnName("fZ2MinDim");

                entity.Property(e => e.FZ2perim).HasColumnName("fZ2Perim");

                entity.Property(e => e.FZ3gbd).HasColumnName("fZ3GBD");

                entity.Property(e => e.FZ3maxDim).HasColumnName("fZ3MaxDim");

                entity.Property(e => e.FZ3minDim).HasColumnName("fZ3MinDim");

                entity.Property(e => e.FZ3perim).HasColumnName("fZ3Perim");

                entity.Property(e => e.FZ4gbd).HasColumnName("fZ4GBD");

                entity.Property(e => e.FZ4maxDim).HasColumnName("fZ4MaxDim");

                entity.Property(e => e.FZ4minDim).HasColumnName("fZ4MinDim");

                entity.Property(e => e.FZ4perim).HasColumnName("fZ4Perim");

                entity.Property(e => e.FZ5gbd).HasColumnName("fZ5GBD");

                entity.Property(e => e.FZ5maxDim).HasColumnName("fZ5MaxDim");

                entity.Property(e => e.FZ5minDim).HasColumnName("fZ5MinDim");

                entity.Property(e => e.FZ5perim).HasColumnName("fZ5Perim");

                entity.Property(e => e.FZ6gbd).HasColumnName("fZ6GBD");

                entity.Property(e => e.FZ6maxDim).HasColumnName("fZ6MaxDim");

                entity.Property(e => e.FZ6minDim).HasColumnName("fZ6MinDim");

                entity.Property(e => e.FZ6perim).HasColumnName("fZ6Perim");

                entity.Property(e => e.VPartNum)
                    .HasMaxLength(50)
                    .HasColumnName("vPartNum");

                entity.Property(e => e.VShellSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("vShellSerialNum");
            });

            modelBuilder.Entity<TblSubAssembly>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSubAssembly");

                entity.Property(e => e.DtAssembly)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAssembly");

                entity.Property(e => e.VBrick1SerialNum)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("vBrick1SerialNum");

                entity.Property(e => e.VBrick2SerialNum)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("vBrick2SerialNum");

                entity.Property(e => e.VConvertorPartNum)
                    .HasMaxLength(50)
                    .HasColumnName("vConvertorPartNum");

                entity.Property(e => e.VMat1SerialNum)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("vMat1SerialNum");

                entity.Property(e => e.VMat2SerialNum)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("vMat2SerialNum");

                entity.Property(e => e.VShellSerialNum)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("vShellSerialNum");

                entity.Property(e => e.VShellSerialNum2)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("vShellSerialNum2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
