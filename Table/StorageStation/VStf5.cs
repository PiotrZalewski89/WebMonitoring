using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class VStf5
    {
        public string OempartNumber { get; set; }
        public string NrLinii { get; set; }
        public string CvmDateofMeasurement { get; set; }
        public string CvmMeasurementOkNok { get; set; }
        public long? FrameTime3 { get; set; }
    }
}
