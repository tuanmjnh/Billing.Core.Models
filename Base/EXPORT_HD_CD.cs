namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("EXPORT_HD_CD")]
    public partial class EXPORT_HD_CD : DANH_BA_KHACH_HANG {
        public Guid CD_ID { get; set; }
        public Guid DBKH_ID { get; set; }
        public DateTime TIME_BILL { get; set; }
        public int APP_ID { get; set; }

        [StringLength(256)]
        public string SO_TB { get; set; }

        [StringLength(256)]
        public string KIEU { get; set; }
        public int? TB_DAUCUOI { get; set; }
        public decimal CUOC_TB { get; set; }
        public decimal CUOC_DV { get; set; }
        public decimal CUOC_NH { get; set; }
        public decimal CUOC_NT { get; set; }
        public decimal CUOC_PSTN { get; set; }
        public decimal CUOC_V171 { get; set; }
        public decimal CUOC_VDNK { get; set; }
        public decimal CUOC_DD { get; set; }
        public decimal CUOC_IDD { get; set; }
        public decimal CUOC_V171Q { get; set; }
        public decimal CUOC_VDNKQ { get; set; }
        public decimal CUOC_CI { get; set; }
        public decimal CUOC_KM { get; set; }
        public decimal CHIET_KHAU { get; set; }
        public decimal TONG_IN { get; set; }
        public decimal TONG { get; set; }
        public decimal VAT { get; set; }
        public decimal TONGCONG { get; set; }
        public int DUPE_FLAG { get; set; }
    }
}