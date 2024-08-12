using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.PIPE
{
    public partial class Ws7NgcAssembling
    {
        public string Code { get; set; }
        public string EngravingCode { get; set; }
        public string WynikOperacji { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}
