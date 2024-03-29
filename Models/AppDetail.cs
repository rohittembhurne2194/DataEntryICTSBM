﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryICTSBM.Models
{
    [Keyless]
    public partial class AppDetail
    {
        public int AppId { get; set; }
        public string AppName { get; set; }
        public string AppName_mar { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> Tehsil { get; set; }
        public Nullable<int> District { get; set; }
        public string EmailId { get; set; }
        public string website { get; set; }
        public string Android_GCM_pushNotification_Key { get; set; }
        public Nullable<bool> IsProduction { get; set; }
        public string baseImageUrlCMS { get; set; }
        public string baseImageUrl { get; set; }
        public string AboutThumbnailURL { get; set; }
        public string AboutAppynity { get; set; }
        public string AboutTeamDetail { get; set; }
        public string ContactUsTeamMember { get; set; }
        public string HomeSplash { get; set; }
        public string FAQ { get; set; }
        public string ContactUs { get; set; }
        public string basePath { get; set; }
        public string yoccContact { get; set; }
        public string Type { get; set; }
        public string Logo { get; set; }
        public string Latitude { get; set; }
        public string Logitude { get; set; }
        public string UserProfile { get; set; }
        public string Collection { get; set; }
        public string HouseQRCode { get; set; }
        public string PointQRCode { get; set; }
        public string HousePDF { get; set; }
        public string PointPDF { get; set; }
        public string Grampanchayat_Pro { get; set; }
        public string AppVersion { get; set; }
        public Nullable<bool> ForceUpdate { get; set; }
        public Nullable<int> APIHit { get; set; }
        public Nullable<bool> NewFeatures { get; set; }
        public Nullable<bool> ReportEnable { get; set; }
        public string DumpYardQRCode { get; set; }
        public string DumpYardPDF { get; set; }
        public Nullable<int> GramPanchyatAppID { get; set; }
        public Nullable<int> YoccClientID { get; set; }
        public string YoccFeddbackLink { get; set; }
        public string YoccDndLink { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public string MsgForBroadcast { get; set; }
        public string MsgForNotSpecified { get; set; }
        public string MsgForMixed { get; set; }
        public string MsgForNotReceived { get; set; }
        public string MsgForSegregated { get; set; }
        public Nullable<bool> IsScanNear { get; set; }
        public string LiquidQRCode { get; set; }
        public string StreetQRCode { get; set; }
        public string CommercialQRCode { get; set; }
        public string CTPTQRCode { get; set; }
        public string SWMQRCode { get; set; }
        public Nullable<int> ulb_property { get; set; }
        public Nullable<int> Add_Ulb_Property { get; set; }
        public Nullable<bool> Today_Waste_Status { get; set; }
        public Nullable<bool> Today_Liquid_Status { get; set; }
        public Nullable<bool> Today_Street_Status { get; set; }
        public Nullable<bool> Status { get; set; }
        public string VehicalQRCode { get; set; }
        public string AppAreaLatLong { get; set; }
        public Nullable<bool> IsAreaActive { get; set; }
        public Nullable<int> Today_HouseScanCount { get; set; }
        public Nullable<int> Today_LiquidScanCount { get; set; }
        public Nullable<int> Today_StreetScanCount { get; set; }
        public Nullable<int> Total_HouseCount { get; set; }
        public Nullable<int> Total_LiquidCount { get; set; }
        public Nullable<int> Total_StreetCount { get; set; }
        public Nullable<int> Today_DumpScanCount { get; set; }
        public Nullable<int> Total_DumpCount { get; set; }
        public string AppLink { get; set; }
        public Nullable<int> Today_MixedCount { get; set; }
        public Nullable<int> Today_SegregatedCount { get; set; }
        public Nullable<int> Today_GarbageNRCount { get; set; }
        public Nullable<int> ulb_Liquid_Property { get; set; }
        public Nullable<int> ulb_Street_Property { get; set; }
        public Nullable<int> ulb_Dump_Property { get; set; }
        public Nullable<int> Total_HouseScan_Property { get; set; }
        public Nullable<int> Total_LiquidScan_Property { get; set; }
        public Nullable<int> Total_StreetScan_Property { get; set; }
        public Nullable<int> Total_DumpScan_Property { get; set; }
        public string AIReportsPath { get; set; }
    }
}
