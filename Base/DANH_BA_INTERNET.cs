namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("DANH_BA_INTERNET")]
    public partial class DANH_BA_INTERNET {
        public string MA_KH { get; set; }
        public string MS_THUE { get; set; }
        public int SOLUONGMAY { get; set; }
        public string SODAIDIEN { get; set; }
        public string MA_CBT { get; set; }
        public string TEN_TT { get; set; }
        public string DIACHI_TT { get; set; }
        public string TAIKHOAN { get; set; }
        public string PHUONG_ID { get; set; }
        public int KHLON_ID { get; set; }
        public string DVQL_ID { get; set; }
        public string ACCOUNT { get; set; }
        public int CUOC_YTE { get; set; }
        public int CUOC_DV { get; set; }
        public int CUOC_TB { get; set; }
        public DateTime NGAY_DKY { get; set; }
        public int THUTU_IN { get; set; }
        public int LOAIKH_ID { get; set; }
        public int TRANGTHAI_ { get; set; }
        public string SOMAY_TN { get; set; }
        public int LOAITB_ID { get; set; }
        public int PHUONGTHUC { get; set; }
        public int NGAY_TB { get; set; }
        public DateTime NGAY_CAT { get; set; }
        public DateTime NGAY_HUY { get; set; }
        public int MA_DT { get; set; }
        public string MA_TUYENTHU { get; set; }
        public string MA_TT_HNI { get; set; }
        public string THUONGHIEU_VTT { get; set; }
        public int DATMOI_TRONGTHANG { get; set; }
        public DateTime NGAY_CHUYEN { get; set; }
        public string MA_TB { get; set; }
        public string DIENTHOAI_LH { get; set; }
    }
}