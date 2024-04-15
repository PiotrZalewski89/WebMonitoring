﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.CNH
{
    public partial class Ws1CnhPetlaKontrolnaL3
    {
        public string NrKatalizatora { get; set; }
        public string NrPaleta { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public string NrOperatora { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public int Id { get; set; }
        public string Quality { get; set; }
        public string AngleInlet { get; set; }
    }
}
