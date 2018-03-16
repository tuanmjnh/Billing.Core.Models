namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("HD_MYTV")]
    public partial class HD_MYTV {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public Guid MYTV_ID { get; set; }
        public Guid DBKH_ID { get; set; }
        public int TYPE_BILL { get; set; }
        public DateTime TIME_BILL { get; set; }

        [StringLength(256)]
        public string ACCOUNT { get; set; }

        [StringLength(512)]
        public string TOC_DO { get; set; }
        public int? TT_THANG { get; set; }
        public int? NGAY_TB { get; set; }
        public int? NGAY_TB_PTTB { get; set; }
        public int? GOICUOCID { get; set; }
        public int? TH_THANG { get; set; }
        public int? TH_HUY { get; set; }
        public int? DUPECOUNT { get; set; }
        public int? ISDATMOI { get; set; }
        public int? ISHUY { get; set; }
        public int? ISTTT { get; set; }
        public int? ISDATCOC { get; set; }
        public decimal PAYTV_FEE { get; set; }
        public decimal SUB_FEE { get; set; }
        public decimal GIAM_TRU { get; set; }
        public decimal TONG_TTT { get; set; }
        public decimal TONG_DC { get; set; }
        public decimal TONG_IN { get; set; }
        public decimal TONG { get; set; }
        public decimal VAT { get; set; }
        public decimal TONGCONG { get; set; }
        //PTTB
        public DateTime? SIGNDATE { get; set; }
        public DateTime? REGISTDATE { get; set; }
        //KTNV
        public DateTime? NGAY_SD { get; set; }
        public DateTime? NGAY_KHOA { get; set; }
        public DateTime? NGAY_MO { get; set; }
        public DateTime? NGAY_KT { get; set; }
    }
}