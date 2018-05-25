namespace Billing.Core.Models {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("DANH_BA_CO_DINH")]
    public partial class DANH_BA_CO_DINH {
        public string MA_CQ { get; set; }
        public string MS_THUE { get; set; }
        public string DVQL_ID { get; set; }
        public string MA_DVQL { get; set; }
        //public string SODAIDIEN { get; set; }
        public string MA_CBT { get; set; }
        public string TEN_TB { get; set; }
        public string DIA_CHI { get; set; }
        public string SO_NHA { get; set; }
        //public string TO_SO { get; set; }
        //public string MA_PX { get; set; }
        //public int SO_TB { get; set; }
        //public int MA_CV { get; set; }
        //public int MA_NV { get; set; }
        //public int CUOC_TB { get; set; }
        //public int CUOC_TK { get; set; }
        public DateTime NGAY_DKY { get; set; }
        public int TRANGTHAI { get; set; }
        public int MA_DT { get; set; }
        //public int MUCUOC_ID { get; set; }
        //public int THUTU_IN { get; set; }
        public int NGAY_TB { get; set; }
        public DateTime NGAY_CAT { get; set; }
        public DateTime NGAY_HUY { get; set; }
        public string TENPHUONG { get; set; }
        public string CMT { get; set; }
        public string MA_TB { get; set; }
        public string MA_TUYENTHU { get; set; }
        public string MA_TT_HNI { get; set; }
        public string MA_KH { get; set; }
        public int DATMOI_TRONGTHANG { get; set; }
        public DateTime NGAY_CHUYEN { get; set; }
        public string DIENTHOAI_LH { get; set; }
        public int DICHVUVT_ID { get; set; }
    }
}