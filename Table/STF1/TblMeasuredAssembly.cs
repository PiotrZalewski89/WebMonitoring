using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.STF1
{
    public partial class TblMeasuredAssembly
    {
        public int NAssemblyUid { get; set; }
        public string VShellSerialNum { get; set; }
        public int? NMachId { get; set; }
        public string VBrick1SerialNum { get; set; }
        public string VMat1SerialNum { get; set; }
        public string VBrick2SerialNum { get; set; }
        public string VMat2SerialNum { get; set; }
        public float? FAvgGbd1 { get; set; }
        public float? FAvgGbd2 { get; set; }
        public DateTime? DtAssembly { get; set; }
        public bool? BPass { get; set; }
        public float? FBrick1Z1avgGbd { get; set; }
        public float? FBrick1Z2avgGbd { get; set; }
        public float? FBrick1Z3avgGbd { get; set; }
        public float? FBrick2Z1avgGbd { get; set; }
        public float? FBrick2Z2avgGbd { get; set; }
        public float? FBrick2Z3avgGbd { get; set; }
        public string VPartNum { get; set; }
    }
}
