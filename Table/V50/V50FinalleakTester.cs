﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.V50
{
    public partial class V50FinalleakTester
    {
        public string NrShellaDoc { get; set; }
        public string NrShellaScrof { get; set; }
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
