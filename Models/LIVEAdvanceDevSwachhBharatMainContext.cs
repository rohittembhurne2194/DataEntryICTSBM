using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryICTSBM.Models
{
    public class LIVEAdvanceDevSwachhBharatMainContext : DbContext
    {

        public LIVEAdvanceDevSwachhBharatMainContext(DbContextOptions<LIVEAdvanceDevSwachhBharatMainContext> options)
          : base(options)
        {
        }


        public virtual DbSet<HouseEntryCount> HouseEntryCount { get; set; }
        public virtual DbSet<AppDetail> AppDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=172.16.0.90;Initial Catalog=LIVEAdvanceDevSwachhBharatMain;User Id=sa; Password=Bi9vAppy;Connection Timeout=3600;");
            }
        }
    }
}
