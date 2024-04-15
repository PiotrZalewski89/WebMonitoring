using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.STF1
{
    public partial class TblBrick
    {
        public string VSerialNum { get; set; }
        public string VPartNum { get; set; }
        public int? NMachId { get; set; }
        public float? FLength { get; set; }
        public DateTime? DtMeasure { get; set; }
        public float? FOrientation { get; set; }
        public bool? BPass { get; set; }
        public int? NStatus { get; set; }
        public float? FAvgPerim { get; set; }
        public float? FZ1perim { get; set; }
        public float? FZ1maxDim { get; set; }
        public float? FZ1minDim { get; set; }
        public int? NZ1polarPairs { get; set; }
        public float? FZ2perim { get; set; }
        public float? FZ2maxDim { get; set; }
        public float? FZ2minDim { get; set; }
        public int? NZ2polarPairs { get; set; }
        public float? FZ3perim { get; set; }
        public float? FZ3maxDim { get; set; }
        public float? FZ3minDim { get; set; }
        public int? NZ3polarPairs { get; set; }
        public bool? BUsedInAssembly { get; set; }
        public int? NBrickNum { get; set; }
    }
}
