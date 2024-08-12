using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.PIPE
{
    public partial class Ws7SdfFinalLeakTester
    {
        public string Code { get; set; }
        public float? Cisnienie { get; set; }
        public string CisnienieJedn { get; set; }
        public float? Wyciek { get; set; }
        public string WyciekJedn { get; set; }
        public string WynikOperacji { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}
