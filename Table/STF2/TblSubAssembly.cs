using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.STF2
{
    public partial class TblSubAssembly
    {
        public string VBrick1SerialNum { get; set; }
        public string VMat1SerialNum { get; set; }
        public string VBrick2SerialNum { get; set; }
        public string VMat2SerialNum { get; set; }
        public string VShellSerialNum { get; set; }
        public string VShellSerialNum2 { get; set; }
        public DateTime? DtAssembly { get; set; }
        public string VConvertorPartNum { get; set; }
    }
}
