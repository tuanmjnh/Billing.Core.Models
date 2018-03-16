namespace Billing.Core.Models {
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;

    [Table("HD_TSL")]
    public partial class HD_TSL {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public Guid ID { get; set; }
        public Guid DBKH_ID { get; set; }
        public int TYPE_BILL { get; set; }
        public DateTime TIME_BILL { get; set; }
        public int MAPHO_ID { get; set; }
        public int THANHTOAN_ID { get; set; }
        public int THUEBAO_ID { get; set; }

        [StringLength(256)]
        public string ACCOUNT { get; set; }

        [StringLength(256)]
        public string MA_TB { get; set; }
        public int DOITUONG_ID { get; set; }

        [StringLength(512)]
        public string TOC_DO { get; set; }

        [StringLength(1024)]
        public string GHICHU { get; set; }
        public int LOAIHINHTB_ID { get; set; }

        [StringLength(256)]
        public string MA_LHTB { get; set; }
        public int? TRANGTHAITB_ID { get; set; }
        public int? TBDAYCHUNG_ID { get; set; }
        public int? GOICUOCID { get; set; }
        public int? ISDATMOI { get; set; }
        public int? ISHUY { get; set; }
        public int? ISTTT { get; set; }
        public int? ISDATCOC { get; set; }
        public decimal GIAM_TRU { get; set; }
        public decimal CUOC_DATA { get; set; }
        public decimal CUOC_SD { get; set; }
        public decimal CUOC_TB { get; set; }
        public decimal TONG_TTT { get; set; }
        public decimal TONG_DC { get; set; }
        public decimal TONG_IN { get; set; }
        public decimal TONG { get; set; }
        public decimal VAT { get; set; }
        public decimal TONGCONG { get; set; }
        public DateTime? NGAY_TTTB { get; set; }
        public DateTime? NGAY_SD { get; set; }
        public DateTime? NGAY_CN { get; set; }
        public DateTime? NGAY_HT { get; set; }
        public DateTime? NGAY_CAT { get; set; }
    }
}