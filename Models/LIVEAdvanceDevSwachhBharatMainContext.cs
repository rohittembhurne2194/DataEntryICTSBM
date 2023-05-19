﻿using Microsoft.EntityFrameworkCore;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=43.242.215.209;Initial Catalog=LIVEAdvanceDevSwachhBharatMain;User Id=appynitty; Password=BigV$Telecom;Connection Timeout=3600;");
            }
        }
    }
}
