using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.STF2
{
    public partial class TblMat
    {
        public string VMatSerialNum { get; set; }
        public float? FMatWeight { get; set; }
        public DateTime? DtMeasure { get; set; }
        public bool? BPass { get; set; }
        public string VPartNum { get; set; }
        public float? FMatArea { get; set; }
        public float? FMatThickness { get; set; }
        public float? FNominalWeight { get; set; }
        public float? FMaxWeight { get; set; }
        public float? FMinWeight { get; set; }
        public string VMatMfgLotNum { get; set; }
        public int? IMatNumber { get; set; }
    }
}
