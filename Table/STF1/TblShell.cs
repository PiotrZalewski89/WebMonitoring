using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.STF1
{
    public partial class TblShell
    {
        public string VSerialNum { get; set; }
        public string VPartNum { get; set; }
        public int? NMachId { get; set; }
        public float? FTargetPerim1 { get; set; }
        public string VTargetGbd1 { get; set; }
        public float? FTargetPerim2 { get; set; }
        public string VTargetGbd2 { get; set; }
        public DateTime? DtTimeOfForm { get; set; }
        public bool? BPass { get; set; }
        public int? NStatus { get; set; }
        public bool? BUsedInAssembly { get; set; }
    }
}
