using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryICTSBM.Models
{
    public class DataEntryDetails
    {
        public string ULB_NAME { get; set; }

        public string Datasource { get; set; }

        public int total_count { get; set; }
        public int updated_count { get; set; }
        public int _count { get; set; }
        public int Todays_count { get; set; }
        public DateTime _date { get; set; }
        public List<DataEntryULBDetailsIteam> ListDataEntryDetails { get; set; }
    }

    
}
