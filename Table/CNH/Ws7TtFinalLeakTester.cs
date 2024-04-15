﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.CNH
{
    public partial class Ws7TtFinalLeakTester
    {
        public string NrShellaDoc { get; set; }
        public string NrShellaScrof { get; set; }
        public string NrShellaScrcuc { get; set; }
        public string NrMixer { get; set; }
        public string NrOslony { get; set; }
        public float? Cisnienie { get; set; }
        public string CisnienieJedn { get; set; }
        public float? Wyciek { get; set; }
        public string WyciekJedn { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}
