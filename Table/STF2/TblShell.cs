using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.STF2
{
    public partial class TblShell
    {
        public string VShellSerialNum { get; set; }
        public float? FAvgGbdregion1 { get; set; }
        public float? FAvgPerimRegion1 { get; set; }
        public float? FAvgGbdregion2 { get; set; }
        public float? FAvgPerimRegion2 { get; set; }
        public bool? BPass { get; set; }
        public DateTime? DtMeasure { get; set; }
        public float? FZ1gbd { get; set; }
        public float? FZ2gbd { get; set; }
        public float? FZ3gbd { get; set; }
        public float? FZ4gbd { get; set; }
        public float? FZ5gbd { get; set; }
        public float? FZ6gbd { get; set; }
        public float? FZ1perim { get; set; }
        public float? FZ2perim { get; set; }
        public float? FZ3perim { get; set; }
        public float? FZ4perim { get; set; }
        public float? FZ5perim { get; set; }
        public float? FZ6perim { get; set; }
        public float? FZ1maxDim { get; set; }
        public float? FZ1minDim { get; set; }
        public float? FZ2maxDim { get; set; }
        public float? FZ2minDim { get; set; }
        public float? FZ3maxDim { get; set; }
        public float? FZ3minDim { get; set; }
        public float? FZ4maxDim { get; set; }
        public float? FZ4minDim { get; set; }
        public float? FZ5maxDim { get; set; }
        public float? FZ5minDim { get; set; }
        public float? FZ6maxDim { get; set; }
        public float? FZ6minDim { get; set; }
        public string VPartNum { get; set; }
        public float? FTargetGbd1 { get; set; }
        public float? FTargetGbd2 { get; set; }
        public float? FWallThickness { get; set; }
        public float? FGbd1plusTolerance { get; set; }
        public float? FGbd1minusTolerance { get; set; }
        public float? FGbd2plusTolerance { get; set; }
        public float? FGbd2minusTolerance { get; set; }
    }
}
