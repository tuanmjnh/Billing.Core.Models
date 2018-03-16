namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("DD")]
    public partial class DD {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public int TYPE_BILL { get; set; }
        public DateTime TIME_BILL { get; set; }
        public int APP_ID { get; set; }

        [StringLength(256)]
        public string MA_KH { get; set; }

        [StringLength(256)]
        public string MA_TT { get; set; }

        [StringLength(256)]
        public string SO_TB { get; set; }

        [StringLength(512)]
        public string TEN_TT { get; set; }

        [StringLength(1024)]
        public string DIACHI_TT { get; set; }

        [StringLength(256)]
        public string BANKNUMBER { get; set; }

        [StringLength(256)]
        public string MS_THUE { get; set; }
        public int? MA_DVI { get; set; }
        public int? MA_CBT { get; set; }
        public int? MA_DVI1 { get; set; }
        public int? MA_CBT1 { get; set; }

        [StringLength(128)]
        public string MA_TUYEN { get; set; }

        [StringLength(256)]
        public string KIEU { get; set; }
        public int INCHITIET { get; set; }
        public int EZPAY { get; set; }
        public int? DTUONG_ID { get; set; }

        [StringLength(128)]
        public string MA_DT { get; set; }
        public int IS_GROUP { get; set; }
        public int SL_MAY { get; set; }
        public decimal TIEN_SDTK { get; set; }
        public decimal CUOC_TB { get; set; }
        public decimal CAREPLUS { get; set; }
        public decimal CUOC_KTHUE { get; set; }
        public decimal CUOC_KM { get; set; }
        public decimal CUOC_CDVU { get; set; }
        public decimal CUOC_TT { get; set; }
        public decimal CUOC_PSDV { get; set; }
        public decimal TIEN_TTRUO { get; set; }
        public decimal TIEN_DCOC { get; set; }
        public decimal GIAM_TRU { get; set; }
        public decimal CUOC_GTRU { get; set; }
        public decimal TONG { get; set; }
        public decimal VAT { get; set; }
        public decimal TONGCONG { get; set; }
        public int DUPE_FLAG { get; set; }
    }
}