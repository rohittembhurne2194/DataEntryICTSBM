using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryICTSBM.Models
{
    [Keyless]
    public class HouseEntryCount
    {
        public string appName { get; set; }
        public string Datasource { get; set; }
        public int total_count { get; set; }
        public int updated_count { get; set; }
        public int _count { get; set; }
        public int Todays_count { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime _date { get; set; }

    }
}
