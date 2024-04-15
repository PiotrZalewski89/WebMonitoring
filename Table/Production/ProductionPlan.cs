using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.Production
{
    public partial class ProductionPlan
    {
        public int Id { get; set; }
        public string Line { get; set; }
        public int Target { get; set; }
        public int? CallendarWeek { get; set; }
        public DateTime? OperationDate { get; set; }
        public string ProductionShift { get; set; }
    }
}
