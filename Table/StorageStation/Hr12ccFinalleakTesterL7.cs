using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class Hr12ccFinalleakTesterL7
    {
        public string NrGrawerka { get; set; }
        public string Cisnienie { get; set; }
        public string CisnienieJedn { get; set; }
        public string Wyciek { get; set; }
        public string WyciekJedn { get; set; }
        public string WartoscPrzeplywuRurki1 { get; set; }
        public string WartoscPrzeplywuRurki2 { get; set; }
        public string WynikTestu { get; set; }
        public string NrLinii { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public DateTime? DtOperacji { get; set; }
    }
}
