﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class PetlaKontrolnaHr16L3
    {
        public string NrGrawerka { get; set; }
        public string NrPaleta { get; set; }
        public string TrybPracy { get; set; }
        public string WynikOperacji { get; set; }
        public string NrOperatora { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public string NrLinii { get; set; }
        public long? FrameTime2 { get; set; }
        public int? FrameSeq2 { get; set; }
        public long? FrameTime3 { get; set; }
        public int? FrameSeq3 { get; set; }
        public int Id { get; set; }
        public string Quality { get; set; }
    }
}
