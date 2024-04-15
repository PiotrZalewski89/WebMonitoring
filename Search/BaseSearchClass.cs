using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Search
{
    public class BaseSearchClass
    {
        public string Brak => "Brak";

        public List<string> HtmlTable { get; set; }
        public string Csv { get; set; }
        public List<string> Table { get; set; }
        public List<string> NameTable { get; set; }
        public List<string> FindData { get; set; }
        public string TextArea { get; set; }

        //selektory
        public bool SelectCode { get; set; }
        public bool SelectDate { get; set; }
        public bool SelectPzzw { get; set; }
        public DateTime? DateTime { get; set; }

        public IList<string> FileName { get; set; }
    }
}
