﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.CNH
{
    public partial class Ws1CnhLeakTesterEtap2
    {
        public string NrBasic { get; set; }
        public string NrShell { get; set; }
        public string Cisnienie { get; set; }
        public string CisnienieJedn { get; set; }
        public string Wyciek { get; set; }
        public string WyciekJedn { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}
