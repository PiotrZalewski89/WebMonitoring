using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebMonitoring.Table.STF1;

#nullable disable

namespace WebMonitoring.DataBase
{
    public partial class Stf1DbContext : DbContext
    {
        public Stf1DbContext()
        {
        }

        public Stf1DbContext(DbContextOptions<Stf1DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBrick> TblBricks { get; set; }
        public virtual DbSet<TblMat> TblMats { get; set; }
        public virtual DbSet<TblMeasuredAssembly> TblMeasuredAssemblies { get; set; }
        public virtual DbSet<TblShell> TblShells { get; set; }
        public virtual DbSet<TblSubAssembly> TblSubAssemblies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source= 172.16.17.203,1433\\\\\\\\789073-001;Initial Catalog= GWS_Rev1;Persist Security Info=True;User ID=pwRoch;Password=pwRoch;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblBrick>(entity =>
            {
                entity.HasKey(e => e.VSerialNum);

                entity.ToTable("tblBricks");

                entity.Property(e => e.VSerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("vSerialNum");

                entity.Property(e => e.BPass).HasColumnName("bPass");

                entity.Property(e => e.BUsedInAssembly).HasColumnName("bUsedInAssembly");

                entity.Property(e => e.DtMeasure)
                    .HasColumnType("datetime")
                    .HasColumnName("dtMeasure");

                entity.Property(e => e.FAvgPerim).HasColumnName("fAvgPerim");

                entity.Property(e => e.FLength).HasColumnName("fLength");

                entity.Property(e => e.FOrientation).HasColumnName("fOrientation");

                entity.Property(e => e.FZ1maxDim).HasColumnName("fZ1MaxDim");

                entity.Property(e => e.FZ1minDim).HasColumnName("fZ1MinDim");

                entity.Property(e => e.FZ1perim).HasColumnName("fZ1Perim");

                entity.Property(e => e.FZ2maxDim).HasColumnName("fZ2MaxDim");

                entity.Property(e => e.FZ2minDim).HasColumnName("fZ2MinDim");

                entity.Property(e => e.FZ2perim).HasColumnName("fZ2Perim");

                entity.Property(e => e.FZ3maxDim).HasColumnName("fZ3MaxDim");

                entity.Property(e => e.FZ3minDim).HasColumnName("fZ3MinDim");

                entity.Property(e => e.FZ3perim).HasColumnName("fZ3Perim");

                entity.Property(e => e.NBrickNum).HasColumnName("nBrickNum");

                entity.Property(e => e.NMachId).HasColumnName("nMachID");

                entity.Property(e => e.NStatus).HasColumnName("nStatus");

                entity.Property(e => e.NZ1polarPairs).HasColumnName("nZ1PolarPairs");

                entity.Property(e => e.NZ2polarPairs).HasColumnName("nZ2PolarPairs");

                entity.Property(e => e.NZ3polarPairs).HasColumnName("nZ3PolarPairs");

                entity.Property(e => e.VPartNum)
                    .HasMaxLength(8)
                    .HasColumnName("vPartNum");
            });

            modelBuilder.Entity<TblMat>(entity =>
            {
                entity.HasKey(e => e.VSerialNum);

                entity.ToTable("tblMats");

                entity.Property(e => e.VSerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("vSerialNum");

                entity.Property(e => e.BPass).HasColumnName("bPass");

                entity.Property(e => e.BUsedInAssembly).HasColumnName("bUsedInAssembly");

                entity.Property(e => e.DtTimeOfMeasure)
                    .HasColumnType("datetime")
                    .HasColumnName("dtTimeOfMeasure");

                entity.Property(e => e.FArea).HasColumnName("fArea");

                entity.Property(e => e.FWeight).HasColumnName("fWeight");

                entity.Property(e => e.NMachId).HasColumnName("nMachID");

                entity.Property(e => e.NMatNum).HasColumnName("nMatNum");

                entity.Property(e => e.NStatus).HasColumnName("nStatus");

                entity.Property(e => e.VPartNum)
                    .HasMaxLength(8)
                    .HasColumnName("vPartNum");
            });

            modelBuilder.Entity<TblMeasuredAssembly>(entity =>
            {
                entity.HasKey(e => e.NAssemblyUid);

                entity.ToTable("tblMeasuredAssemblies");

                entity.Property(e => e.NAssemblyUid).HasColumnName("nAssemblyUid");

                entity.Property(e => e.BPass).HasColumnName("bPass");

                entity.Property(e => e.DtAssembly)
                    .HasColumnType("datetime")
                    .HasColumnName("dtAssembly");

                entity.Property(e => e.FAvgGbd1).HasColumnName("fAvgGBD1");

                entity.Property(e => e.FAvgGbd2).HasColumnName("fAvgGBD2");

                entity.Property(e => e.FBrick1Z1avgGbd).HasColumnName("fBrick1Z1AvgGBD");

                entity.Property(e => e.FBrick1Z2avgGbd).HasColumnName("fBrick1Z2AvgGBD");

                entity.Property(e => e.FBrick1Z3avgGbd).HasColumnName("fBrick1Z3AvgGBD");

                entity.Property(e => e.FBrick2Z1avgGbd).HasColumnName("fBrick2Z1AvgGBD");

                entity.Property(e => e.FBrick2Z2avgGbd).HasColumnName("fBrick2Z2AvgGBD");

                entity.Property(e => e.FBrick2Z3avgGbd).HasColumnName("fBrick2Z3AvgGBD");

                entity.Property(e => e.NMachId).HasColumnName("nMachID");

                entity.Property(e => e.VBrick1SerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("vBrick1SerialNum");

                entity.Property(e => e.VBrick2SerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("vBrick2SerialNum");

                entity.Property(e => e.VMat1SerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("vMat1SerialNum");

                entity.Property(e => e.VMat2SerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("vMat2SerialNum");

                entity.Property(e => e.VPartNum)
                    .HasMaxLength(8)
                    .HasColumnName("vPartNum");

                entity.Property(e => e.VShellSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("vShellSerialNum");
            });

            modelBuilder.Entity<TblShell>(entity =>
            {
                entity.HasKey(e => e.VSerialNum);

                entity.ToTable("tblShells");

                entity.Property(e => e.VSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("vSerialNum");

                entity.Property(e => e.BPass).HasColumnName("bPass");

                entity.Property(e => e.BUsedInAssembly).HasColumnName("bUsedInAssembly");

                entity.Property(e => e.DtTimeOfForm)
                    .HasColumnType("datetime")
                    .HasColumnName("dtTimeOfForm");

                entity.Property(e => e.FTargetPerim1).HasColumnName("fTargetPerim1");

                entity.Property(e => e.FTargetPerim2).HasColumnName("fTargetPerim2");

                entity.Property(e => e.NMachId).HasColumnName("nMachID");

                entity.Property(e => e.NStatus).HasColumnName("nStatus");

                entity.Property(e => e.VPartNum)
                    .HasMaxLength(8)
                    .HasColumnName("vPartNum");

                entity.Property(e => e.VTargetGbd1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vTargetGBD1");

                entity.Property(e => e.VTargetGbd2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vTargetGBD2");
            });

            modelBuilder.Entity<TblSubAssembly>(entity =>
            {
                entity.HasKey(e => e.NSubAssemblyUid)
                    .HasName("PK_tblSubAssembly_1");

                entity.ToTable("tblSubAssembly");

                entity.HasIndex(e => e.NSubAssemblyUid, "IX_tblSubAssembly");

                entity.Property(e => e.NSubAssemblyUid).HasColumnName("nSubAssemblyUid");

                entity.Property(e => e.VBrick1SerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("vBrick1SerialNum");

                entity.Property(e => e.VBrick2SerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("vBrick2SerialNum");

                entity.Property(e => e.VMat1SerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("vMat1SerialNum");

                entity.Property(e => e.VMat2SerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("vMat2SerialNum");

                entity.Property(e => e.VShellSerialNum)
                    .HasMaxLength(60)
                    .HasColumnName("vShellSerialNum");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
