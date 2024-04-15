using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.CNH
{
    public partial class CnhWs1MeasuredAssembly
    {
        public string ShellSerialNum { get; set; }
        public int? Id { get; set; }
        public DateTime? DtAssembly { get; set; }
        public string Pass { get; set; }
        public int? MachId { get; set; }
        public string Brick1SerialNum { get; set; }
        public string Mat1SerialNum { get; set; }
        public string Brick2SerialNum { get; set; }
        public string Mat2SerialNum { get; set; }
        public string PartNum { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}
