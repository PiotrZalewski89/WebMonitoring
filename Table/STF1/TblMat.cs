using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.STF1
{
    public partial class TblMat
    {
        public string VSerialNum { get; set; }
        public string VPartNum { get; set; }
        public int? NMachId { get; set; }
        public float? FArea { get; set; }
        public float? FWeight { get; set; }
        public DateTime? DtTimeOfMeasure { get; set; }
        public bool? BPass { get; set; }
        public int? NStatus { get; set; }
        public bool? BUsedInAssembly { get; set; }
        public int? NMatNum { get; set; }
    }
}
