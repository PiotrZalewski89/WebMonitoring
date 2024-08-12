using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.PIPE
{
    public partial class Ws7SdfControlLoop
    {
        public string EngravingCode { get; set; }
        public string OrderNo { get; set; }
        public bool? Result { get; set; }
        public DateTime? DtOperation { get; set; }
        public string OperatorId { get; set; }
        public string Quality { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}
